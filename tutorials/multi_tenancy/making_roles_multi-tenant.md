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
public class RoleSaveHandler : SaveRequestHandlerAsync<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
{
    //...
    protected override async Task SetInternalFieldsAsync(CancellationToken cancellationToken = default)
    {
        await base.SetInternalFieldsAsync(cancellationToken);

        if (IsCreate)
            Row.TenantId = User.GetTenantId();
    }

    protected override async Task ValidateRequestAsync(CancellationToken cancellationToken = default)
    {
        await base.ValidateRequestAsync(cancellationToken);

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
public class RoleDeleteHandler : DeleteRequestHandlerAsync<MyRow, MyRequest, MyResponse>, IRoleDeleteHandler
{
    //...
    protected override async Task ValidateRequestAsync(CancellationToken cancellationToken = default)
    {
        await base.ValidateRequestAsync(cancellationToken);

        if (Row.TenantId != User.GetTenantId())
            Permissions.ValidatePermission(PermissionKeys.Tenants, Localizer);
    }
}
```

```csharp
//...
public class RoleRetrieveHandler : RetrieveRequestHandlerAsync<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    //...
    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }
    protected override async Task PrepareQueryAsync(SqlQuery query,
        CancellationToken cancellationToken = default)
    {
        await base.PrepareQueryAsync(query, cancellationToken);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(Fld.TenantId == User.GetTenantId());
    }
}
```

```csharp
//...
public class RoleListHandler : ListRequestHandlerAsync<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    //...
    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }
    protected override async Task ApplyFiltersAsync(SqlQuery query,
        CancellationToken cancellationToken = default)
    {
        await base.ApplyFiltersAsync(query, cancellationToken);

        if (!Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(Fld.TenantId == User.GetTenantId());
    }
}
```

