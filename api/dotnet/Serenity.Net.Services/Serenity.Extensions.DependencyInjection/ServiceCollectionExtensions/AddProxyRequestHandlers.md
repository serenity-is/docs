# ServiceCollectionExtensions.AddProxyRequestHandlers method

Registers proxy activators for the DI container to resolve generic request handler instances like [`ICreateHandler`](../../Serenity.Services/ICreateHandler-1.md), [`IListHandler`](../../Serenity.Services/IListHandler-1.md) etc.

```csharp
public static IServiceCollection AddProxyRequestHandlers(this IServiceCollection collection)
```

| parameter | description |
| --- | --- |
| collection | Service collection |

## Remarks

These open-generic proxies let the container resolve a handler by its generic request-handler interface (e.g. [`ICreateHandler`](../../Serenity.Services/ICreateHandler-1.md), [`IListHandler`](../../Serenity.Services/IListHandler-1.md)) without requiring a per-entity handler interface. They were introduced while migrating from the repository to the handler pattern, to ease that transition. The code generator now emits a per-entity handler interface and class (e.g. `IOrderSaveHandler`/`OrderSaveHandler`), which is the recommended approach; these proxies remain as a compatibility/fallback path. They are registered after custom handlers, so a concrete handler (which also implements the generic interface) takes precedence.

## See Also

* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)