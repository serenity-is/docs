# Setting TenantId For New Users

While logged in with Tenant2, try to create a new user, *User2*.

You won't get any error but by surprise, you won't see the newly created user in list. What happened to User2?

As we set default value for *TenantId* to *1* in migrations, now *User2* has *1* as *TenantId* and is a member of *Primary Tenant*.

We have to set new users *TenantId* to same value with logged in user.

Modify *SetInternalFields* method of *UserSaveHandler* like below:

```cs
protected override void SetInternalFields()
{
    base.SetInternalFields();

    if (IsCreate)
    {
        Row.Source = "site";
        Row.IsActive = Row.IsActive ?? 1;
        if (!Permissions.HasPermission(PermissionKeys.Tenants) ||
            Row.TenantId == null)
        {
            Row.TenantId = User.GetTenantId();
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

Here, we set *TenantId* to the same value with current user, unless he has tenant administration permission.

Now try to create a new user *User2b* and this time you'll see him on the list.

