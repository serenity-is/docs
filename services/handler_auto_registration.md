# Auto-Registration of Request Handlers

Serenity automatically registers request handlers from the type source — you don't have to add an `AddSingleton`/`AddTransient` line for each handler.

## AddServiceHandlers

Everything starts with `AddServiceHandlers()`, called from `Startup.ConfigureServices`. It registers the core services and the handlers:

```cs
public static IServiceCollection AddServiceHandlers(this IServiceCollection collection,
    ITypeSource customHandlerTypeSource = null, Func<Type, Type, bool> customHandlerPredicate = null)
{
    collection.AddCaching();
    collection.AddEntities();
    collection.AddFeatureToggles();
    collection.AddTextRegistry();
    collection.AddServiceHandlerFactory();
    collection.AddServiceResolver();
    collection.AddCustomRequestHandlers(customHandlerTypeSource, customHandlerPredicate);
    collection.AddProxyRequestHandlers();

    collection.TryAddSingleton<IRequestContext, DefaultRequestContext>();
    return collection;
}
```

The relevant call for handler discovery is [AddCustomRequestHandlers](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions/AddCustomRequestHandlers.md). It is called by `AddServiceHandlers()`, along with the other registrations shown above (`AddCaching`, `AddEntities`, `AddFeatureToggles`, `AddTextRegistry`, `AddServiceBehaviors`, `AddServiceHandlerFactory`, `AddServiceResolver`, `AddUserProvider`, and `AddProxyRequestHandlers`).

## How AddCustomRequestHandlers Works

[AddCustomRequestHandlers](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions/AddCustomRequestHandlers.md) does the following:

1. **Scans the type source** for all types implementing [IRequestHandler](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRequestHandler.md) (via `GetTypesWithInterface(typeof(IRequestHandler))`). This is why custom handlers must implement `IRequestHandler` — see [Custom Request Handlers](custom_request_handlers.md).
2. **Registers each concrete handler type** as transient for itself.
3. **Registers each handler for its interfaces**, as long as the interface derives from `IRequestHandler`. The base marker interfaces are skipped:
   - `IRequestHandler`, `ISaveRequestHandler`, `IListRequestHandler`, `IRetrieveRequestHandler`, `IDeleteRequestHandler`, `IUndeleteRequestHandler` and their `*Processor` / `*ProcessorAsync` counterparts;
   - the generic `IRequestHandler<,,>`, `IRequestHandler<>`, `IRequestType<>`, `IResponseType<>` interfaces (these are covered by [AddProxyRequestHandlers](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions/AddProxyRequestHandlers.md)).
4. **Handles multiple implementations**: if more than one handler implements the same interface, one must be marked with [DefaultHandler(true)](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultHandlerAttribute.md) — otherwise an `InvalidProgramException` is thrown asking you to pick a default.

Because handlers are registered as transient, each request gets a fresh handler instance.

### The predicate parameter

`AddCustomRequestHandlers` (and `AddServiceHandlers`) accepts an optional predicate: `(intf, impl) => bool`. Returning `false` for a pair skips that registration. For example, to register handlers only for their interfaces (not for themselves):

```cs
services.AddServiceHandlers(customHandlerPredicate: (intf, impl) => intf != impl);
```

> The default (no predicate) registers both the concrete handler types and their interfaces.

## Proxy Request Handlers

[AddProxyRequestHandlers](../api/dotnet/Serenity.Net.Services/Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions/AddProxyRequestHandlers.md) registers transient proxies that let the DI container resolve the generic handler interfaces like `ICreateHandler<TRow>`, `IUpdateHandler<TRow>`, `IDeleteHandler<TRow>`, `IListHandler<TRow>`, `IRetrieveHandler<TRow>`, and `IUndeleteHandler<TRow>` on demand — even when the concrete handler is only registered for its own specific interface (e.g. `ILanguageSaveHandler`).

The same proxies are registered for the async variants: `ICreateHandlerAsync<TRow>`, `IUpdateHandlerAsync<TRow>`, `IDeleteHandlerAsync<TRow>`, `IListHandlerAsync<TRow>`, `IRetrieveHandlerAsync<TRow>`, and `IUndeleteHandlerAsync<TRow>`. These resolve the async handler (e.g. `SaveRequestHandlerAsync<TRow>`) and expose `CreateAsync`/`UpdateAsync`/... methods that accept a `CancellationToken`.

When a custom handler is only implemented for one mode (sync or async), the proxy can still resolve the other mode: [`DefaultHandlerFactory`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultHandlerFactory.md) detects the companion interface and wraps the custom handler so the requested mode is served — an async request for a row whose only custom handler is synchronous returns the sync handler wrapped in a `SyncToAsync...` adapter, and vice versa. This means existing synchronous custom handlers keep working unchanged from asynchronous code.

> Every handler receives an [`IRequestContext`](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRequestContext.md) through its constructor, and the built-in handlers derive from [`BaseRequestHandler`](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseRequestHandler.md). See [Request Context](request-context.md) for what the context provides and how the base class exposes it.

## Handler Registry, Factory & Activator

Beyond DI registration, Serenity has a small pipeline that resolves and creates the *default* handler for a given row type and handler interface at runtime. This is what behaviors like `MasterDetailRelationBehavior` use to save detail rows through their own handlers.

The three pieces are registered by `AddServiceHandlerFactory()`:

| Interface | Default implementation | Role |
| --- | --- | --- |
| [`IDefaultHandlerRegistry`](../api/dotnet/Serenity.Net.Services/Serenity.Services/IDefaultHandlerRegistry.md) | [`DefaultHandlerRegistry`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultHandlerRegistry.md) | Discovers candidate handler classes from the type source (all concrete types implementing `IRequestHandler`) |
| [`IDefaultHandlerFactory`](../api/dotnet/Serenity.Net.Services/Serenity.Services/IDefaultHandlerFactory.md) | [`DefaultHandlerFactory`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultHandlerFactory.md) | Picks the concrete handler type for a `(rowType, handlerInterface)` pair and caches it |
| [`IHandlerActivator`](../api/dotnet/Serenity.Net.Services/Serenity.Services/IHandlerActivator.md) | [`DefaultHandlerActivator`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultHandlerActivator.md) | Creates an instance of the chosen handler type via the DI container |

`DefaultHandlerFactory.CreateHandler(rowType, handlerInterface)` resolves the handler type like this:

1. Asks the registry for all handler classes assignable to the requested handler interface (or its sync/async companion) that also implement `IRequestHandler<TRow>` and are not marked `[DefaultHandler(false)]`.
2. If exactly one matches, uses it.
3. If none match, falls back to the interface's [`GenericHandlerTypeAttribute`](../api/dotnet/Serenity.Net.Services/Serenity.Services/GenericHandlerTypeAttribute.md) (e.g. `ISaveRequestProcessorAsync` is annotated with `[GenericHandlerType(typeof(SaveRequestHandlerAsync<>))]`) and closes the generic over the row type.
4. If several match, picks the one marked [`[DefaultHandler(true)]`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultHandlerAttribute.md); otherwise it throws `InvalidProgramException` telling you to add `[DefaultHandler]`.

When the only matching custom handler implements the *companion* (other mode) interface rather than the requested one, the factory returns the handler wrapped in the appropriate adapter (see [Proxy Request Handlers](#proxy-request-handlers) above), so custom handler logic is never silently skipped.

The typed helper [`DefaultHandlerFactoryExtensions.CreateHandler<THandler>(rowType)`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DefaultHandlerFactoryExtensions.md) wraps this for a specific handler interface:

```cs
var saveHandler = handlerFactory.CreateHandler<ISaveRequestProcessorAsync>(rowType);
```

### Request & response types

Handler interfaces can declare their request and response types through the marker interfaces [`IRequestType<TRequest>`](../api/dotnet/Serenity.Net.Services/Serenity.Services/IRequestType-1.md) and [`IResponseType<TResponse>`](../api/dotnet/Serenity.Net.Services/Serenity.Services/IResponseType-1.md). [`RequestHandlerExtensions`](../api/dotnet/Serenity.Net.Services/Serenity.Services/RequestHandlerExtensions.md) reads them from a handler instance:

- `GetRequestType(handler)` / `GetResponseType(handler)` — reflect the generic arguments.
- `CreateRequest(handler)` — creates a new request object for the handler (e.g. `ListRequest`, `SaveRequest<TRow>`, `DeleteRequest`, ...).

These are mostly used internally (e.g. by service endpoints to build a request), but you may see them when writing generic code that works with any handler.

## See Also

- [Request Context](request-context.md)
- [Custom Request Handlers](custom_request_handlers.md)
- [Generating Handler Interfaces](generate_interface.md)
- [Service Behaviors](behaviors.md)
- [Service Endpoints](service_endpoints.md)
- [Dependency Injection](../framework/dependency-injection.md)
