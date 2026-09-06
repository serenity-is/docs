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
    IRetrieveBehaviorAsync, IListBehaviorAsync,
    ISaveBehaviorAsync, IDeleteBehaviorAsync
{
    private Int32Field tenantIdField;

    public bool ActivateFor(IRow row)
    {
        if (row is not IMultiTenantRow mtRow)
            return false;

        tenantIdField = mtRow.TenantIdField;
        return true;
    }

    public Task OnPrepareQueryAsync(IRetrieveRequestHandler handler,
        SqlQuery query, CancellationToken cancellationToken = default)
    {
        if (!handler.Context.Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(tenantIdField == handler.Context.User.GetTenantId());
        return Task.CompletedTask;
    }

    public Task OnPrepareQueryAsync(IListRequestHandler handler,
        SqlQuery query, CancellationToken cancellationToken = default)
    {
        if (!handler.Context.Permissions.HasPermission(PermissionKeys.Tenants))
            query.Where(tenantIdField == handler.Context.User.GetTenantId());
        return Task.CompletedTask;
    }

    public Task OnSetInternalFieldsAsync(ISaveRequestHandler handler,
        CancellationToken cancellationToken = default)
    {
        if (handler.IsCreate)
            tenantIdField[handler.Row] = handler.Context.User.GetTenantId();
        return Task.CompletedTask;
    }

    public Task OnValidateRequestAsync(ISaveRequestHandler handler,
        CancellationToken cancellationToken = default)
    {
        if (handler.IsUpdate)
        {
            if (tenantIdField[handler.Old] != tenantIdField[handler.Row])
                handler.Context.Permissions.ValidatePermission(PermissionKeys.Tenants, handler.Context.Localizer);
        }
        return Task.CompletedTask;
    }

    public Task OnValidateRequestAsync(IDeleteRequestHandler handler,
        CancellationToken cancellationToken = default)
    {
        if (tenantIdField[handler.Row] != handler.Context.User.GetTenantId())
            handler.Context.Permissions.ValidatePermission(PermissionKeys.Tenants, handler.Context.Localizer);
        return Task.CompletedTask;
    }

    // the remaining hooks are optional — the async behavior interfaces
    // provide default no-op implementations for every member
}
```

Behavior classes implementing the `IImplicitBehavior` interface determine whether they should be activated for a specific row type.

Behaviors achieve this by overriding the `ActivateFor` method, which is invoked by request handlers.

Within this method, we verify whether the row type implements the `IMultiTenantRow` interface. If it does not, the method simply returns `false`.

Subsequently, we obtain a private reference to the `TenantIdField` to reuse it in other methods.

The `ActivateFor` method is invoked only once per handler type and row. If this method returns `true`, the behavior instance is cached aggressively for performance reasons and reused for any request involving the corresponding row and handler type.

Therefore, all code implemented in other methods must be thread-safe, as a single instance is shared across all requests. Additionally, consider utilizing `IServiceResolver<MyDependency>` to resolve any additional dependencies.

A behavior may intercept one or more of the `Retrieve`, `List`, `Save`, or `Delete` handlers by implementing the corresponding asynchronous behavior interfaces: `IRetrieveBehaviorAsync`, `IListBehaviorAsync`, `ISaveBehaviorAsync`, or `IDeleteBehaviorAsync`.

In this context, we need to intercept all of these service calls, so we implement all relevant interfaces.

Because the async behavior interfaces provide default no-op implementations for every member, we only override the methods that are necessary for our purposes. The methods take a `CancellationToken` and return `Task`; hooks that do no asynchronous work may simply return `Task.CompletedTask`.

The methods implemented here correspond to those overridden in `RoleRepository.cs` in the previous section. The code within these methods is nearly identical; however, in this behavior, we ensure it is more generic to accommodate any row type that implements the `IMultiTenantRow` interface.

## Reimplementing `RoleRepository` Using the Behavior

Now, revert all changes previously made to `RoleRepository.cs`:

```cs
//...
public class RoleSaveHandler : SaveRequestHandlerAsync<MyRow, MyRequest, MyResponse>, IRoleSaveHandler
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

public class RoleDeleteHandler : DeleteRequestHandlerAsync<MyRow, MyRequest, MyResponse>, IRoleDeleteHandler
{
    public RoleDeleteHandler(IRequestContext context)
         : base(context)
    {
    }
}

public class RoleRetrieveHandler : RetrieveRequestHandlerAsync<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    public RoleRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}

public class RoleListHandler : ListRequestHandlerAsync<MyRow, MyRequest, MyResponse>, IRoleListHandler
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