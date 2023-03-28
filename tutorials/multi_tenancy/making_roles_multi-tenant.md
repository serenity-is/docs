# Making Roles Multi-Tenant

So far, we have made users page work in multi-tenant style. Seems like we did too many changes to make it work. But remember that we are trying to turn a system that is not designed to be multi-tenant into such one.

Let's apply similar principles to the Roles table.

Again, a user in one tenant shouldn't see or modify roles in other tenants and work in isolation.

We start by adding *TenantId* property to *RoleRow.cs*:

```csharp
namespace MultiTenancy.Administration
{
    //...
    public sealed class RoleRow : Row<RoleRow.RowFields>, IIdRow, INameRow
    {
        [Insertable(false), Updatable(false)]
        public int? TenantId
        {
            get => Fields.TenantId[this];
            set => Fields.TenantId[this] = value;
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

Then we'll do several changes in *RequestsHandlers*:

```csharp
public class RoleSaveHandler :  SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
{
    //...
    
    protected override void SetInternalFields()
    {
        base.SetInternalFields();

        if (IsCreate)
            Row.TenantId = User.GetTenantId();
    }

    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        if (IsUpdate)
        {
            if (Old.TenantId != User.GetTenantId())
                Permissions.ValidatePermission(PermissionKeys.Tenants, Localizer);
        }
    }
}

public class RoleDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoleDeleteHandler
{
    //...
    
    protected override void ValidateRequest()
    {
        base.ValidateRequest();

        if (Row.TenantId != User.GetTenantId())
            Permissions.ValidatePermission(PermissionKeys.Tenants, Localizer);
    }
}

public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    //...

    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(fld.TenantId == User.GetTenantId());
    }
}

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    //...

    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(fld.TenantId == User.GetTenantId());
    }
}
```

