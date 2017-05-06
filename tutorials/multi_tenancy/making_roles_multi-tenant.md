# Making Roles Multi-Tenant

So far, we have made users page work in multi-tenant style. Seems like we did too many changes to make it work. But remember that we are trying to turn a system that is not designed to be multi-tenant into such one.

Let's apply similar principles to the Roles table.

Again, a user in one tenant shouldn't see or modify roles in other tenants and work in isolation.

We start by adding *TenantId* property to *RoleRow.cs*:

```cs
namespace MultiTenancy.Administration.Entities
{
    //...
    public sealed class RoleRow : Row, IIdRow, INameRow
    {
        [Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }
        
        //...
        
        public class RowFields : RowFieldsBase
        {
            //...
            public Int32Field TenantId;
            //...
        }
    }
}
```

Then we'll do several changes in *RoleRepository.cs*:

```cs
private class MySaveHandler : SaveRequestHandler<MyRow>
{
    protected override void SetInternalFields()
    {
        base.SetInternalFields();

        if (IsCreate)
            Row.TenantId = ((UserDefinition)Authorization.UserDefinition).TenantId;
    }
}

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

private class MyListHandler : ListRequestHandler<MyRow>
{
    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);

        var user = (UserDefinition)Authorization.UserDefinition;
        if (!Authorization.HasPermission(PermissionKeys.Tenants))
            query.Where(fld.TenantId == user.TenantId);
    }
}
```

