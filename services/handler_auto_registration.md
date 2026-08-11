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
   - `IRequestHandler`, `ISaveRequestHandler`, `IListRequestHandler`, `IRetrieveRequestHandler`, `IDeleteRequestHandler`, `IUndeleteRequestHandler` and their `*Processor` counterparts;
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

## See Also

- [Custom Request Handlers](custom_request_handlers.md)
- [Generating Handler Interfaces](generate_interface.md)
- [Service Endpoints](service_endpoints.md)
- [Dependency Injection](../framework/dependency-injection.md)
