# 为新用户设置 TenantId  

当我们使用 Tenant2 登录系统，并尝试创建一个新用户 *User2*。

你不会收到任何错误，但令人惊讶的是，你不能在列表中看到新创建的用户， User2 发生了什么？

由于我们在迁移类中，把 *TenantId* 的值设置为 *1*，现在 *User2* 的 *TenantId* 也是 *1*，并且它也是 *主租客*。 

我们需要在已登录的用户中把新用户的 *TenantId* 设置为同样的值。

修改 *UserRepository* 的 *SetInternalFields* 方法：

```cs
protected override void SetInternalFields()
{
    base.SetInternalFields();

    if (IsCreate)
    {
        Row.Source = "site";
        Row.IsActive = Row.IsActive ?? 1;
        if (!Authorization.HasPermission(Administration.PermissionKeys.Tenants) ||
            Row.TenantId == null)
        {
            Row.TenantId = ((UserDefinition)Authorization.UserDefinition)
                .TenantId;
        }
    }

    if (IsCreate || !Row.Password.IsEmptyOrNull())
    {
        string salt = null;
        Row.PasswordHash = GenerateHash(password, ref salt);
        Row.PasswordSalt = salt;
    }
}
```

除非有租户管理权限，否则我们在这里把该 *TenantId* 设置为与当前用户相同的值。

现在尝试创建一个新用户 *User2b*，这次你将在列表中看到新建的用户。

