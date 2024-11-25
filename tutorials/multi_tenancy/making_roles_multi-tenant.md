# Making Roles Multi-Tenant

To date, we have adapted the users page to operate in a multi-tenant fashion. While this required numerous modifications, it is important to recognize that we are transforming a system originally not designed for multi-tenancy into one that accommodates it.

We will apply similar principles to the Roles table.

Specifically, a user within one tenant should neither view nor modify roles associated with other tenants, ensuring isolated operation.

We begin by adding the `TenantId` property to `RoleRow.cs`:

```csharp
//...
namespace MovieTutorial.Administration;

//...
public sealed class RoleRow : Row<RoleRow.RowFields>, IIdRow, INameRow
{
    //...
    [Insertable(false), Updatable(false)]
    public int? TenantId { get => Fields.TenantId[this]; set => Fields.TenantId[this] = value; }

    public class RowFields : RowFieldsBase
    {
        //...
        public Int32Field TenantId;
    }
}
```

Next, we will make several changes to the *RequestsHandlers*:

```csharp
//...
public class RoleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
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
```

```csharp
//...
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
```

```csharp
//...
public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    //...
    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }
    protected override void PrepareQuery(SqlQuery query)
    {
        base.PrepareQuery(query);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(Fld.TenantId == User.GetTenantId());
    }
}
```

```csharp
//...
public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    //...
    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }
    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(Fld.TenantId == User.GetTenantId());
    }
}
```

