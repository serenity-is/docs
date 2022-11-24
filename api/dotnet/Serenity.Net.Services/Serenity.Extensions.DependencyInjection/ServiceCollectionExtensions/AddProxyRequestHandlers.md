# ServiceCollectionExtensions.AddProxyRequestHandlers method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Registers proxy activators for the DI container to resolve generic request handler instances like [`ICreateHandler`](../../Serenity.Services/ICreateHandler-1.md), [`IListHandler`](../../Serenity.Services/IListHandler-1.md) etc.

```csharp
public static IServiceCollection AddProxyRequestHandlers(this IServiceCollection collection)
```

| parameter | description |
| --- | --- |
| collection | Service collection |

## See Also

* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)