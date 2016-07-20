# 隐藏租户管理权限

我们现在有点问题：因为用户 *tenant2* 有 *Administration:Security* 权限，所以他可以访问用户和角色权限对话框。因此，他可以使用权限 UI 给自己授予 *Administration:Tenants* 权限。

![Tenant2 Granting Himself](img/tenant2_granting_tenants.png)

Serenity 扫描程序集的特性，比如 *ReadPermission*、*WritePermission*、*PageAuthorize*、*ServiceAuthorize* 等，并在编辑权限对话框列出这些权限。

我们应该先从默认值列表中删除它。

在 UserPermissionRepository.cs 找到 *ListPermissionKeys* 方法：

```
public ListResponse<string> ListPermissionKeys()
{
    return LocalCache.Get("Administration:PermissionKeys", TimeSpan.Zero, () =>
    {
        //...

        result.Remove(Administration.PermissionKeys.Tenants);
        result.Remove("*");
        result.Remove("?");
        
        //...
```

现在，该权限不会在 *编辑用户权限* 或 *编辑角色权限* 对话框中被列出来。

但是，黑客仍然可以通过 *UserPermissionRepository.Update* 或 *RolePermissionRepository.Update* 方法给自己授权。

我们应该添加一些检查来阻止该行为：

```cs
public class UserPermissionRepository
{
    public SaveResponse Update(IUnitOfWork uow, 
        UserPermissionUpdateRequest request)
    {
        //...
        var newList = new Dictionary<string, bool>(
            StringComparer.OrdinalIgnoreCase);
        foreach (var p in request.Permissions)
            newList[p.PermissionKey] = p.Grant ?? false;

        var allowedKeys = ListPermissionKeys()
            .Entities.ToDictionary(x => x);
        if (newList.Keys.Any(x => !allowedKeys.ContainsKey(x)))
            throw new AccessViolationException();
        //...

```

```cs
public class RolePermissionRepository
{
    public SaveResponse Update(IUnitOfWork uow, 
        RolePermissionUpdateRequest request)
    {
        //...
        var newList = new HashSet<string>(
            request.Permissions.ToList(),
            StringComparer.OrdinalIgnoreCase);

        var allowedKeys = new UserPermissionRepository()
            .ListPermissionKeys()
            .Entities.ToDictionary(x => x);
        if (newList.Any(x => !allowedKeys.ContainsKey(x)))
            throw new AccessViolationException();
        //...
```

在这里，我们认为任何试图授权不在权限对话框列表的新访问许可键都是一个黑客行为。

> 实际上，即使在非多租户系统中也应该默认做这个检查，但是通常我们信任管理的用户。在这里，管理员只能管理他们自己的租户，所以我们必须包含该检查。