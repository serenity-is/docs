# Hiding the Tenant Administration Permission

We now have one little problem. User *tenant2* has permission *Administration:Security* so he can access user and role permission dialogs. Thus, he can grant himself *Administration:Tenants* permission using the permission UI.

![Tenant2 Granting Himself](img/tenant2_granting_tenants.png)

Serenity scans your assemblies for attributes like *ReadPermission*, *WritePermission*, *PageAuthorize*, *ServiceAuthorize* etc. and lists these permissions in edit permissions dialog.

We should first remove it from this pre-populated list.

Find method, *ListPermissionKeys* in *UserPermissionRepository.cs*:

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

Now, this permission won't be listed in *Edit User Permissions* or *Edit Role Permissions* dialog.

But, still, he can grant this permission to himself, by some little hacking through *UserPermissionRepository.Update* or *RolePermissionRepository.Update* methods.

We should add some checks to prevent this:

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

Here we check if any of the new permission keys that are tried to be granted, are not listed in permission dialog. If so, this is probably a hack attempt.

> Actually this check should be the default, even without multi-tenant systems, but usually we trust administrative users.