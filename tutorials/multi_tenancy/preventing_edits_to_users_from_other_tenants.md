# Preventing Edits To Users From Other Tenants

Remember that user *tenant2* could update his *TenantId* with some service call, and we had to secure it server side.

Similar to this, even if he can't see users from other tenants by default, he can actually retrieve and update them.

Time to hack again.

Open Chrome console and type this:

```js
new MultiTenancy.Administration.UserDialog().loadByIdAndOpenDialog(1)
```

As you see, anyone could open user dialog for *admin* and update it.

*MultiTenancy.Administration.UserDialog* is the dialog class that is opened when you click a username in user administration page.

We created a new instance of it, and asked to load a user entity by its ID. Admin user has an ID of *1*.

To load the entity with ID 1, dialog called *Retrieve* service of *UserRepository*.

Remember that we did filtering in *List* method of *UserRepository*, not *Retrieve*. So, service has no idea, if it should return this record from another tenant, or not.

It's time to secure retrieve service in UserRepository:

```cs
private class MyRetrieveHandler : RetrieveRequestHandler<MyRow>
{
    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(fld.TenantId == User.GetTenantId());
    }
}
```

We did same changes in MyListHandler before.

If you try same Javascript code now, you'll get an error:

```txt
Record not found. It might be deleted or you don't have required permissions!
```

But, we could still update record calling `Update` service manually. So, we need to secure *MySaveHandler* too.

Change its *ValidateRequest* method like this:

```cs
protected override void ValidateRequest()
{
    base.ValidateRequest();

    if (IsUpdate)
    {
        if (Old.TenantId != User.GetTenantId())
            Permissions.ValidatePermission(PermissionKeys.Tenants, Context.Localizer);
            
        // ...
```

Here we check if it's an update, and if *TenantId* of record being updated (Old.TenantId) is different than currently logged user's *TenantId*. If so, we call *Authorization.ValidatePermission* method to ensure that user has tenant administration permission. It will raise an error if not.

```
Authorization has been denied for this request!
```

## Preventing To Delete Users From Other Tenants

There are delete and undelete handlers in UserRepository, and they suffer from similar security holes.

Using similar methods, we need to secure them too:

```cs
private class MyDeleteHandler : DeleteRequestHandler<MyRow>
{
    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        if (Row.TenantId != User.GetTenantId())
            Permissions.ValidatePermission(PermissionKeys.Tenants, Context.Localizer);
    }
}

private class MyUndeleteHandler : UndeleteRequestHandler<MyRow>
{
    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        if (Row.TenantId != User.GetTenantId())
            Permissions.ValidatePermission(PermissionKeys.Tenants, Context.Localizer);
    }
}
```