# Service Behaviors

Serenity request handlers expose their lifecycle through virtual methods you can override in a generated handler. But when the same logic must apply to many entities — audit logging, multi-tenancy, unique constraints, master–detail saving, row localization — repeating it in every handler is impractical.

**Behaviors** solve this. A behavior is a class that plugs into a handler's lifecycle and is activated based on the row type (or a field), so it runs automatically for every matching handler. They are the recommended way to add cross-cutting concerns to the service layer.

> The built-in features — capture log, insert/update log, localization, master–detail, linking set, unique constraints, and more — are all implemented as behaviors. See [Built-in Service Behaviors](built-in-behaviors.md).

## Behavior Interfaces

Each handler type has a matching pair of behavior interfaces — a **synchronous** one (`...Sync`) and an **asynchronous** one (`...Async`). A single behavior class can implement one or more of these interfaces to participate in the corresponding handlers:

| Interface (Async) | Interface (Sync) | Handler it participates in |
| --- | --- | --- |
| [ISaveBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/ISaveBehaviorAsync.md) | [ISaveBehaviorSync](../api/dotnet/Serenity.Net.Services/Serenity.Services/ISaveBehaviorSync.md) | Save (Create / Update) |
| [IListBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/IListBehaviorAsync.md) | [IListBehaviorSync](../api/dotnet/Serenity.Net.Services/Serenity.Services/IListBehaviorSync.md) | List |
| [IDeleteBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/IDeleteBehaviorAsync.md) | [IDeleteBehaviorSync](../api/dotnet/Serenity.Net.Services/Serenity.Services/IDeleteBehaviorSync.md) | Delete |
| [IRetrieveBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRetrieveBehaviorAsync.md) | [IRetrieveBehaviorSync](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRetrieveBehaviorSync.md) | Retrieve |
| [IUndeleteBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/IUndeleteBehaviorAsync.md) | [IUndeleteBehaviorSync](../api/dotnet/Serenity.Net.Services/Serenity.Services/IUndeleteBehaviorSync.md) | Undelete |

The two interfaces in a pair both derive from a common marker interface ([ISaveBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/ISaveBehavior.md), [IListBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IListBehavior.md), etc.) which is what the behavior provider resolves against.

> Since handlers are now asynchronous by default, implement the **`...Async`** interface (or derive from a `Base...BehaviorAsync` base class) for new behaviors. The sync variants are still fully supported — async request handlers automatically wrap synchronous behaviors, and sync handlers wrap asynchronous behaviors — so a behavior implementing either variant works with both handler modes.

There are also a few special interfaces:

| Interface | Purpose |
| --- | --- |
| [IListMapFieldExpressionBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IListMapFieldExpressionBehavior.md) | List — map a field to a custom SQL expression |
| [IFieldBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IFieldBehavior.md) | Any — targets a single field |

There are also optional **exception** interfaces for handling errors raised during the operation:

- [ISaveExceptionBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/ISaveExceptionBehavior.md)
- [IDeleteExceptionBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IDeleteExceptionBehavior.md)
- [IRetrieveExceptionBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRetrieveExceptionBehavior.md)
- [IListExceptionBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IListExceptionBehavior.md)
- [IUndeleteExceptionBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IUndeleteExceptionBehavior.md)

These let a behavior inspect an exception raised by the database operation and, for example, translate a foreign-key or primary-key error into a friendlier validation message. Exception hooks are synchronous (`OnException(...)`) in both variants — they only inspect the exception and optionally throw a translated one, so they don't need to be async.

## Base Classes

Instead of implementing every method of an interface, derive from the corresponding base class which provides empty virtual methods. There is a base for each mode:

- [BaseSaveBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseSaveBehaviorAsync.md) — async save behavior (implements `ISaveBehaviorAsync` and `ISaveExceptionBehavior`).
- [BaseSaveDeleteBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseSaveDeleteBehaviorAsync.md) — combines async save and delete, for behaviors that need to act on both (e.g. audit logs, master–detail).
- [BaseListBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseListBehaviorAsync.md) — async list behavior.
- [BaseDeleteBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseDeleteBehaviorAsync.md) — async delete behavior (implements `IDeleteBehaviorAsync` and `IDeleteExceptionBehavior`).
- [BaseRetrieveBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseRetrieveBehaviorAsync.md) — async retrieve behavior.
- [BaseUndeleteBehaviorAsync](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseUndeleteBehaviorAsync.md) — async undelete behavior (implements `IUndeleteBehaviorAsync` and `IUndeleteExceptionBehavior`).

And the corresponding synchronous bases — [BaseSaveBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseSaveBehavior.md), [BaseSaveDeleteBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseSaveDeleteBehavior.md), [BaseListBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseListBehavior.md), [BaseDeleteBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseDeleteBehavior.md), [BaseRetrieveBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseRetrieveBehavior.md), [BaseUndeleteBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseUndeleteBehavior.md). These are kept for behaviors that predate the async migration and are marked **obsolete**.

You then override only the methods you need.

> A single behavior class may implement **both** the sync and async variants of an interface (and derive from the async base, overriding the sync methods too). Some framework behaviors such as `MasterDetailRelationBehavior` do this so they run natively in both handler modes without being wrapped. Usually, implementing just one variant is enough — the framework wraps it for the other mode.

## How Behaviors Are Attached

A behavior is attached to a row type in one of two ways: **implicitly** (the behavior decides which rows it applies to) or **explicitly** (the row or field declares it with an attribute).

### Implicit Behaviors (`IImplicitBehavior`)

Most behaviors implement [IImplicitBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IImplicitBehavior.md), which has a single method:

```cs
public interface IImplicitBehavior
{
    bool ActivateFor(IRow row);
}
```

`ActivateFor` returns `true` when the behavior should be used for the given row type. Because the behavior is a [singleton](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultImplicitBehaviorRegistry.md) that is cached and reused across requests, it is called **once per handler type and row type**, and is a good place to read attribute/interface metadata and store it in private fields.

For example, the framework's capture-log behavior only activates for rows that have an id and are decorated with `[CaptureLog]`:

```cs
public class CaptureLogBehavior : BaseSaveDeleteBehaviorAsync, IImplicitBehavior
{
    private CaptureLogAttribute captureLogAttr;

    public bool ActivateFor(IRow row)
    {
        if (row is not IIdRow)
            return false;

        captureLogAttr = row.GetType().GetCustomAttribute<CaptureLogAttribute>();
        return captureLogAttr != null;
    }
}
```

Because all `IImplicitBehavior` types are discovered through the type source, you never have to register them manually — `AddServiceBehaviors()` picks them up automatically.

### Explicitly Attaching a Behavior (`[AddBehavior]`)

The [AddBehavior](../api/dotnet/Serenity.Net.Services/Serenity.ComponentModel/AddBehaviorAttribute.md) attribute attaches a specific behavior type to a row class or a field property:

```cs
[AddBehavior(typeof(MyCustomBehavior))]
public sealed class MyRow : Row<MyRow.RowFields>, IIdRow
{
}
```

This is useful when a behavior should not be first-class (e.g. it is specific to one row) or when its activation must be declared rather than inferred.

### Field Behaviors (`IFieldBehavior`)

A behavior that implements [IFieldBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/IFieldBehavior.md) is given a `Target` field before `ActivateFor` is called:

```cs
public interface IFieldBehavior
{
    Field Target { get; set; }
}
```

This lets a single implicit behavior instance work on a per-field basis. For example, the framework's `UniqueFieldSaveBehavior` and the `NotesBehavior` in the Northwind demo both use this to operate on whichever field they are applied to. When resolving a field behavior, the provider creates one instance per field and sets `Target` before checking `ActivateFor`.

### How Behaviors Are Resolved

Behaviors are resolved through [IBehaviorProvider](../api/dotnet/Serenity.Net.Services/Serenity.Services/IBehaviorProvider.md), which is available on the handler's `Context.Behaviors`:

```cs
public interface IRequestContext
{
    IBehaviorProvider Behaviors { get; }
    // ...
}
```

The default resolution logic (in [DefaultBehaviorProvider](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultBehaviorProvider.md)) gathers, in order:

1. Every implicit behavior whose `ActivateFor(row)` returns `true` for the row type.
2. Every behavior explicitly attached to the row class via `[AddBehavior]`.
3. Every field behavior attached to a field via `[AddBehavior]`.

Behaviors are instantiated by [DefaultBehaviorFactory](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultBehaviorFactory.md) using the DI container, so you can inject dependencies (e.g. `ITextLocalizer`, `ISqlConnections`, `IDefaultHandlerFactory`) into a behavior's constructor.

`IBehaviorProvider`, `IBehaviorFactory`, and `IImplicitBehaviorRegistry` are registered as singletons by [AddServiceBehaviors](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions/AddServiceBehaviors.md), which is called by `AddServiceHandlers()` during startup. See [Auto-Registration of Request Handlers](handler_auto_registration.md).

### How sync and async behaviors interoperate

The handler resolves behaviors through the common marker interface (e.g. `ISaveBehavior`), then adapts them to its own mode. The handlers use [BehaviorProviderExtensions.AutoWrapBehaviors](../api/dotnet/Serenity.Net.Services/Serenity.Services/BehaviorProviderExtensions/AutoWrapBehaviors.md) internally:

- An **async** handler keeps behaviors that implement the `...Async` interface as-is and wraps behaviors that only implement the `...Sync` interface in a `SyncToAsync...` wrapper that calls the sync methods and returns `Task.CompletedTask`.
- A **sync** handler does the reverse: behaviors that only implement `...Async` are wrapped in an `AsyncToSync...` wrapper that invokes their async methods and blocks on the result.

A behavior that implements both variants is always used as-is. The wrappers expose the original behavior through the `IWrappedBehavior` interface so framework code can still check for optional interfaces (such as `ISaveExceptionBehavior`) on the underlying behavior.

## Behavior Lifecycle

A behavior's methods are called at specific points in the handler lifecycle. The base classes already wire this up, so implement only the hooks you need.

The hook names below are the **async** variants used by the async handler bases (e.g. `OnBeforeSaveAsync`). The synchronous variants (`OnBeforeSave`, `OnValidateRequest`, ...) follow the same order and are used by the sync handler bases. Every async hook takes a `CancellationToken cancellationToken = default` and returns `Task`, so you can `await` inside it.

### Save (Create / Update)

For a save request, the async handler:

1. Loads the old entity (only for updates) — calls **`OnPrepareQueryAsync`** on each save behavior.
2. Validates the request — calls **`OnValidateRequestAsync`**.
3. Sets internal fields — calls **`OnSetInternalFieldsAsync`**.
4. Runs before the insert/update — calls **`OnBeforeSaveAsync`**.
5. Executes the SQL statement. On failure, calls **`OnException`** on save behaviors that implement `ISaveExceptionBehavior`.
6. Runs after the insert/update — calls **`OnAfterSaveAsync`**.
7. Performs auditing — calls **`OnAuditAsync`**.
8. Returns the response — calls **`OnReturnAsync`**.

```mermaid
sequenceDiagram
    participant H as SaveRequestHandlerAsync
    participant B as SaveBehaviorAsync
    H->>B: OnPrepareQueryAsync (updates only)
    H->>B: OnValidateRequestAsync
    H->>B: OnSetInternalFieldsAsync
    H->>B: OnBeforeSaveAsync
    H->>B: (OnException if SQL fails)
    H->>B: OnAfterSaveAsync
    H->>B: OnAuditAsync
    H->>B: OnReturnAsync
```

### List

For a list request, the async handler:

1. Validates the request — calls **`OnValidateRequestAsync`**.
2. Builds the query — calls **`OnPrepareQueryAsync`**.
3. Applies filters — calls **`OnApplyFiltersAsync`**.
4. Runs before the query is executed — calls **`OnBeforeExecuteQueryAsync`**.
5. Executes the query. On failure, calls **`OnException`** on behaviors implementing `IListExceptionBehavior`.
6. Runs after the query is executed — calls **`OnAfterExecuteQueryAsync`**.
7. Returns the response — calls **`OnReturnAsync`**.

### Delete

For a delete request, the async handler:

1. Loads the entity to delete — calls **`OnPrepareQueryAsync`** (via `LoadEntityAsync`).
2. Validates the request — calls **`OnValidateRequestAsync`**.
3. Runs before the delete — calls **`OnBeforeDeleteAsync`**.
4. Executes the delete. On failure, calls **`OnException`** on behaviors implementing `IDeleteExceptionBehavior`.
5. Runs after the delete — calls **`OnAfterDeleteAsync`**.
6. Audits — calls **`OnAuditAsync`**.
7. Returns the response — calls **`OnReturnAsync`**.

### Retrieve

For a retrieve request, the async handler:

1. Validates the request — calls **`OnValidateRequestAsync`**.
2. Builds the query — calls **`OnPrepareQueryAsync`**.
3. Runs before the query — calls **`OnBeforeExecuteQueryAsync`**.
4. Executes the query. On failure, calls **`OnException`**.
5. Runs after the query — calls **`OnAfterExecuteQueryAsync`**.
6. Returns the response — calls **`OnReturnAsync`**.

### Undelete

For an undelete request, the async handler:

1. Loads the entity — calls **`OnPrepareQueryAsync`**.
2. Validates the request — calls **`OnValidateRequestAsync`**.
3. Runs before the undelete — calls **`OnBeforeUndeleteAsync`**.
4. Executes the undelete. On failure, calls **`OnException`**.
5. Runs after the undelete — calls **`OnAfterUndeleteAsync`**.
6. Audits — calls **`OnAuditAsync`**.
7. Returns the response — calls **`OnReturnAsync`**.

## Writing a Behavior

The simplest behavior only needs to implement one hook and be activated implicitly.

### Example: Humanizing SQL Exceptions

StartSharp ships a `HumanizeSqlExceptionBehavior` in `StartSharp.Common` that translates raw SQL errors into friendly validation messages for save and delete:

```cs
using Microsoft.Data.SqlClient;

namespace StartSharp.Common;

public class HumanizeSqlExceptionBehavior : BaseSaveDeleteBehaviorAsync, IImplicitBehavior
{
    public bool ActivateFor(IRow row)
    {
        return true;
    }

    public override void OnException(ISaveRequestHandler handler, Exception exception)
    {
        if (exception is SqlException)
            SqlExceptionHelper.HandleSavePrimaryKeyException(exception, handler.Context?.Localizer,
                handler.Row?.IdField?.GetTitle(handler.Context?.Localizer));
    }

    public override void OnException(IDeleteRequestHandler handler, Exception exception)
    {
        if (exception is SqlException)
            SqlExceptionHelper.HandleDeleteForeignKeyException(exception, handler.Context?.Localizer);
    }
}
```

Because it derives from `BaseSaveDeleteBehaviorAsync`, it can override the (synchronous) `OnException` method for both save and delete — exception hooks are sync in both the async and sync behavior bases, since they only translate an exception. Since it implements `IImplicitBehavior` and `ActivateFor` always returns `true`, it applies to every row type, which is exactly what you want for a global exception handler.

### Example: Multi-Tenant Behavior

A common cross-cutting behavior is row-level multi-tenancy. The [Multi-Tenancy tutorial](../tutorials/multi_tenancy/using_serenity_service_behaviors.md) builds one that intercepts Retrieve, List, Save, and Delete for any row implementing an `IMultiTenantRow` interface:

```cs
public interface IMultiTenantRow
{
    Int32Field TenantIdField { get; }
}

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
        if (handler.IsUpdate && tenantIdField[handler.Old] != tenantIdField[handler.Row])
            handler.Context.Permissions.ValidatePermission(PermissionKeys.Tenants, handler.Context.Localizer);
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

> The async behavior interfaces provide **default implementations** for their methods, so you only override the hooks you need — no more empty method stubs for every interface member. (The sync `...Sync` interfaces work the same way.) If a hook does no I/O, returning `Task.CompletedTask` is fine; if it does, mark the method `async` and `await` it.

This lets the behavior replace the manual `RoleRepository` plumbing from the earlier part of the tutorial, and apply the same plan automatically to every row type that implements `IMultiTenantRow`.

## Important Notes

- **Behaviors are cached and reused across requests.** A single behavior instance is shared for all requests targeting the same row and handler type. Do not store per-request state in private fields — use the handler's `StateBag` (`handler.StateBag`) instead. All methods must be thread-safe.
- **`ActivateFor` runs once per handler type and row type.** It is a good place to read row/field metadata and cache it in private fields.
- **Constructor injection works.** Behaviors are created through the DI container, so you can inject services like `ITextLocalizer`, `ISqlConnections`, `IDefaultHandlerFactory`, or `IServiceResolver<T>`.
- **A behavior can implement multiple interfaces.** For example, `BaseSaveDeleteBehaviorAsync` covers both save and delete, and `CaptureLogBehavior` additionally implements `IUndeleteBehaviorAsync`.
- **Implement one mode or both.** Implementing just the async interfaces is enough for new behaviors — sync handlers wrap async behaviors automatically, and async handlers wrap sync behaviors. Implementing both variants lets a behavior run natively in both modes without wrapping.
- **Behaviors run for every handler of the matching type.** They are found through the type source, so you can add cross-cutting logic once instead of overriding methods in each handler.

## See Also

- [Built-in Service Behaviors](built-in-behaviors.md)
- [Save Request Handler](save_request_handler.md)
- [List Request Handler](list_request_handler.md)
- [Delete Request Handler](delete_request_handler.md)
- [Undelete Request Handler](undelete_request_handler.md)
- [Custom Request Handlers](custom_request_handlers.md)
- [Auto-Registration of Request Handlers](handler_auto_registration.md)
- [Generating Handler Interfaces](generate_interface.md)
- [Service Endpoints](service_endpoints.md)
- [Using Serenity Service Behaviors (Multi-Tenancy tutorial)](../tutorials/multi_tenancy/using_serenity_service_behaviors.md)
