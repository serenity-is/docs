# Using Serenity Service Behaviors

To extend this multi-tenant system to other tables in MovieDB, we would need to repeat the same steps applied to Roles. Although the process may seem straightforward, it involves substantial manual effort.

Serenity provides a service behavior system that allows you to intercept Create, Update, Retrieve, List, and Delete handlers, enabling the addition of custom code to them.

Some operations within these handlers, such as logging and unique constraint validation, are already implemented as service behaviors.

Behaviors can be activated for all rows or based on specific criteria, such as possessing a particular attribute or implementing an interface. For example, `CaptureLogBehavior` activates for rows with the `[CaptureLog]` attribute.

First, we will define an interface, `IMultiTenantRow`, that will trigger our new behavior. Place this interface in the `IMultiTenantRow.cs` file, located alongside `TenantRow.cs`:

```cs
namespace MovieTutorial;

public interface IMultiTenantRow
{
    Int32Field TenantIdField { get; }
}
```

Then, add this behavior to the `MultiTenantBehavior.cs` file located alongside it:

```cs
using MovieTutorial;

namespace MovieTutorial;

public class MultiTenantBehavior : IImplicitBehavior,
    ISaveBehavior, IDeleteBehavior,
    IListBehavior, IRetrieveBehavior
{
    private Int32Field tenantIdField;

    public bool ActivateFor(IRow row)
    {
        if (row is not IMultiTenantRow mtRow)
            return false;

        tenantIdField = mtRow.TenantIdField;
        return true;
    }

    public void OnPrepareQuery(IRetrieveRequestHandler handler,
        SqlQuery query)
    {
        if (!handler.Context.Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(tenantIdField == handler.Context.User.GetTenantId());
    }

    public void OnPrepareQuery(IListRequestHandler handler,
        SqlQuery query)
    {
        if (!handler.Context.Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(tenantIdField == handler.Context.User.GetTenantId());
    }

    public void OnSetInternalFields(ISaveRequestHandler handler)
    {
        if (handler.IsCreate)
            tenantIdField[handler.Row] = handler.Context.User.GetTenantId();
    }

    public void OnValidateRequest(ISaveRequestHandler handler)
    {
        if (handler.IsUpdate)
        {
            if (tenantIdField[handler.Old] != tenantIdField[handler.Row])
                handler.Context.Permissions.ValidatePermission(PermissionKeys.Tenants, handler.Context.Localizer);
        }
    }

    public void OnValidateRequest(IDeleteRequestHandler handler)
    {
        if (tenantIdField[handler.Row] != handler.Context.User.GetTenantId())
            handler.Context.Permissions.ValidatePermission(PermissionKeys.Tenants, handler.Context.Localizer);
    }

    public void OnAfterDelete(IDeleteRequestHandler handler) { }
    public void OnAfterExecuteQuery(IRetrieveRequestHandler handler) { }
    public void OnAfterExecuteQuery(IListRequestHandler handler) { }
    public void OnAfterSave(ISaveRequestHandler handler) { }
    public void OnApplyFilters(IListRequestHandler handler, SqlQuery query) { }
    public void OnAudit(IDeleteRequestHandler handler) { }
    public void OnAudit(ISaveRequestHandler handler) { }
    public void OnBeforeDelete(IDeleteRequestHandler handler) { }
    public void OnBeforeExecuteQuery(IRetrieveRequestHandler handler) { }
    public void OnBeforeExecuteQuery(IListRequestHandler handler) { }
    public void OnBeforeSave(ISaveRequestHandler handler) { }
    public void OnPrepareQuery(IDeleteRequestHandler handler, SqlQuery query) { }
    public void OnPrepareQuery(ISaveRequestHandler handler, SqlQuery query) { }
    public void OnReturn(IDeleteRequestHandler handler) { }
    public void OnReturn(IRetrieveRequestHandler handler) { }
    public void OnReturn(IListRequestHandler handler) { }
    public void OnReturn(ISaveRequestHandler handler) { }
    public void OnValidateRequest(IRetrieveRequestHandler handler) { }
    public void OnValidateRequest(IListRequestHandler handler) { }
}
```

Behavior classes implementing the `IImplicitBehavior` interface determine whether they should be activated for a specific row type.

Behaviors achieve this by overriding the `ActivateFor` method, which is invoked by request handlers.

Within this method, we verify whether the row type implements the `IMultiTenantRow` interface. If it does not, the method simply returns `false`.

Subsequently, we obtain a private reference to the `TenantIdField` to reuse it in other methods.

The `ActivateFor` method is invoked only once per handler type and row. If this method returns `true`, the behavior instance is cached aggressively for performance reasons and reused for any request involving the corresponding row and handler type.

Therefore, all code implemented in other methods must be thread-safe, as a single instance is shared across all requests. Additionally, consider utilizing `IServiceResolver<MyDependency>` to resolve any additional dependencies.

A behavior may intercept one or more of the `Retrieve`, `List`, `Save`, or `Delete` handlers by implementing the corresponding interfaces: `IRetrieveBehavior`, `IListBehavior`, `ISaveBehavior`, or `IDeleteBehavior`.

In this context, we need to intercept all of these service calls, so we implement all relevant interfaces.

We only implement the methods that are necessary for our purposes and leave the others empty.

The methods implemented here correspond to those overridden in `RoleRepository.cs` in the previous section. The code within these methods is nearly identical; however, in this behavior, we ensure it is more generic to accommodate any row type that implements the `IMultiTenantRow` interface.

## Reimplementing `RoleRepository` Using the Behavior

Now, revert all changes previously made to `RoleRepository.cs`:

```cs
//...
public class RoleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
{
    public RoleSaveHandler(IRequestContext context)
         : base(context)
    {
    }

    protected override void InvalidateCacheOnCommit()
    {
        base.InvalidateCacheOnCommit();

        Cache.InvalidateOnCommit(UnitOfWork, UserPermissionRow.Fields);
        Cache.InvalidateOnCommit(UnitOfWork, RolePermissionRow.Fields);
    }
}

public class RoleDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoleDeleteHandler
{
    public RoleDeleteHandler(IRequestContext context)
         : base(context)
    {
    }
}

public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    public RoleRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}
```

Next, add the `IMultiTenantRow` interface to `RoleRow`:

```cs
namespace MovieTutorial.Administration;

//...
public sealed class RoleRow : Row<RoleRow.RowFields>, IIdRow, INameRow, IMultiTenantRow
{
    //...
    public Int32Field TenantIdField { get => Fields.TenantId; }
    //...
}
```

This approach achieves the same results with significantly less code. Declarative programming is generally preferred.