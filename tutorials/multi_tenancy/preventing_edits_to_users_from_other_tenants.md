# Preventing Edits To Users From Other Tenants

Remember that user *tenant2* could update his *TenantId* with some service call, and we had to secure it server side.

Similar to this, even if he can't see users from other tenants by default, he can actually retrieve and update them.

Time to hack again.

Open Chrome console and type this:

```js
new MultiTenancy.Administration.UserDialog().loadByIdAndOpenDialog(1)
```

What? He could open user dialog for *admin* and update it!

*MultiTenancy.Administration.UserDialog* is the dialog class that is opened when you click a username in user administration page.

We created a new instance of it, and asked to load a user entity by its ID. Admin user has an ID of *1*.

So, to load the entity with ID 1, dialog called *Retrieve* service of *UserRepository*.

Remember that we did filtering in *List* method of *UserRepository*, not *Retrieve*. So, service has no idea, if it should return this record from another tenant, or not.

It's time to secure retrieve service in UserRepository:

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

We did same changes in MyListHandler before.

