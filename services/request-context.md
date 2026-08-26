# Request Context

Every request handler receives an [`IRequestContext`](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRequestContext.md) through its constructor. It is a service-context object (similar in spirit to `HttpContext`, but specialized for service handlers) that bundles the services most handlers need, so you don't have to inject each one separately.

## `IRequestContext`

| Member | Type | Purpose |
| --- | --- | --- |
| `Behaviors` | `IBehaviorProvider` | Resolves the behaviors attached to the handler's row |
| `Cache` | `ITwoLevelCache` | Two-level cache (see [Caching](../framework/caching.md)) |
| `Localizer` | `ITextLocalizer` | Text localizer for translating messages |
| `Permissions` | `IPermissionService` | Permission checks |
| `User` | `ClaimsPrincipal` | The current user |

## `DefaultRequestContext`

[`DefaultRequestContext`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultRequestContext.md) is the default implementation of `IRequestContext`. It is registered as a singleton by `AddServiceHandlers()` during startup:

```cs
collection.TryAddSingleton<IRequestContext, DefaultRequestContext>();
```

It pulls `Behaviors`, `Cache`, `Localizer`, and `Permissions` from DI and resolves `User` through `IUserAccessor`.

## `BaseRequestHandler`

[`BaseRequestHandler`](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseRequestHandler.md) is the abstract base class for request handlers. It takes an `IRequestContext` and exposes the same services as protected properties, so derived handlers can use them without injecting each service separately:

```cs
public abstract class BaseRequestHandler(IRequestContext context) : IRequestHandler
{
    protected ITwoLevelCache Cache => Context.Cache;
    protected IRequestContext Context { get; }
    protected ITextLocalizer Localizer => Context.Localizer;
    protected IPermissionService Permissions => Context.Permissions;
    protected ClaimsPrincipal User => Context.User;
}
```

All the built-in CRUD handlers (`SaveRequestHandler`, `ListRequestHandler`, `RetrieveRequestHandler`, `DeleteRequestHandler`, `UndeleteRequestHandler`) derive from it, and custom handlers can too — see [Custom Request Handlers](custom_request_handlers.md).

> [`BaseRepository`](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseRepository.md) is an older, now-obsolete base class with the same shape, kept for repositories that predate the handler system. Prefer `BaseRequestHandler` for new code.

## Where the context is used

The request context is not limited to request handlers. It is also injected into:

- **Service endpoints** — `ServiceEndpoint` exposes it as a protected `Context` property.
- **Behaviors** — behavior constructors can take `IRequestContext` (or individual services from it) via DI.
- **Repositories / other service classes** — any class that needs cache, localizer, permissions, or the current user can take `IRequestContext` and read them from it.

## See Also

- [Auto-Registration of Request Handlers](handler_auto_registration.md)
- [Custom Request Handlers](custom_request_handlers.md)
- [Service Endpoints](service_endpoints.md)
- [Service Behaviors](behaviors.md)
- [Dependency Injection](../framework/dependency-injection.md)
- API reference: [`IRequestContext`](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRequestContext.md),
  [`DefaultRequestContext`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultRequestContext.md),
  [`BaseRequestHandler`](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseRequestHandler.md),
  [`BaseRepository`](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseRepository.md)