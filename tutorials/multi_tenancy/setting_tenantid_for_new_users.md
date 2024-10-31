# Setting TenantId For New Users

While logged in with _Tenant2_ , try to create a new user, *User2*.

You will not encounter any errors; however, the newly created user will not appear in the list.

Since the default value for `TenantId` is set to *1* in the migrations, User2 has a `TenantId` of 1 and is a member of the *Primary Tenant*

To ensure that new users have the same *TenantId* as the currently logged-in user, modify the `SetInternalFields` method of the `UserSaveHandler` as shown below:

```cs
protected override void SetInternalFields()
{
    base.SetInternalFields();

    if (IsCreate)
    {
        Row.Source = "site";
        Row.IsActive = Row.IsActive ?? 1;
        if (!Permissions.HasPermission(PermissionKeys.Tenants) || Row.TenantId == null)
            Row.TenantId = User.GetTenantId();
    }

    if (IsCreate || !Row.Password.IsEmptyOrNull())
    {
        string salt = null;
        Row.PasswordHash = UserHelper.GenerateHash(password, ref salt);
        Row.PasswordSalt = salt;
    }
}
```

In this modification, we set the `TenantId` to match the current user's `TenantId`, unless the user has tenant administration permissions.

Now, try creating a new user, *User2b*. This time, the user will appear in the list as expected.

