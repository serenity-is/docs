# 防止编辑其他租户的用户

记住，使用 *tenant2* 可以在一些服务调用中更新自己的 *TenantId*，我们需要在服务器端对它进行安全检测。

与此类似，即使默认情况下，不能看到其他租户的用户，但实际上可以检索和更新他们。

又到了黑客时间。

打开 Chrome 的控制台，并输入：

```js
new MultiTenancy.Administration.UserDialog().loadByIdAndOpenDialog(1)
```

什么？可以打开 Admin 的用户对话框并更新内容！

*MultiTenancy.Administration.UserDialog* 是当你在用户管理页面单击用户名时所打开的对话框类。

我们创建一个新的对话框实例，并且使用 ID 加载用户实体。Admin 用户的 ID 是 1。

因此，对话框调用 *UserRepository* 的 *Retrieve* 服务加载 ID 为 1 的实体。

记住，我们在 *UserRepository* 的 *List* 方法做过滤。所以，服务也不知道是否应该返回另一租户的记录。

此时，应该在 UserRepository 对 retrieve 服务做安全检测。

```cs
private class MyRetrieveHandler : RetrieveRequestHandler<MyRow>
{
    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);

        var user = (UserDefinition)Authorization.UserDefinition;
        if (!Authorization.HasPermission(PermissionKeys.Tenants))
            query.Where(fld.TenantId == user.TenantId);
    }
}
```

我们之前在 MyListHandler 中做了同样的修改。

如果你现在尝试运行同样的 Javascript 代码，你将得到一个错误：

```
Record not found. It might be deleted or you don't have required permissions!
```

但是，我们依然可以手工调用 `Update` 服务更新记录。所以，也需要在 *MySaveHandler* 中做安全检测。

把 *ValidateRequest* 方法修改为：

```
protected override void ValidateRequest()
{
    base.ValidateRequest();

    if (IsUpdate)
    {
        var user = (UserDefinition)Authorization.UserDefinition;
        if (Old.TenantId != user.TenantId)
            Authorization.ValidatePermission(PermissionKeys.Tenants);
            
        // ...
```

我们在这里检测是否是更新，如果要更新记录的 *TenantId*(Old.TenantId) 与当前登录用户的 *TenantId* 不相等时，我们调用 *Authorization.ValidatePermission* 方法确保该用户有租户的管理权限，如果没有该权限，将抛出错误。

```
Authorization has been denied for this request!
```

## 防止删除其他租户的用户

在 UserRepository 中有删除和更新处理，并且他们有类似的安全漏洞。

使用类似的方法，我们也需要对它们进行安全检测：

```cs
private class MyDeleteHandler : DeleteRequestHandler<MyRow>
{
    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        var user = (UserDefinition)Authorization.UserDefinition;
        if (Row.TenantId != user.TenantId)
            Authorization.ValidatePermission(PermissionKeys.Tenants);
    }
}

private class MyUndeleteHandler : UndeleteRequestHandler<MyRow>
{
    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        var user = (UserDefinition)Authorization.UserDefinition;
        if (Row.TenantId != user.TenantId)
            Authorization.ValidatePermission(PermissionKeys.Tenants);
    }
}
```