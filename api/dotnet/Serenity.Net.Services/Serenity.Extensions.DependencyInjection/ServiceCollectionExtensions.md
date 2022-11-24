# ServiceCollectionExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains dependency injection extensions for IServiceCollection

```csharp
public static class ServiceCollectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddBaseTexts](ServiceCollectionExtensions/AddBaseTexts.md)(…) | Adds nested texts, enum texts, permission texts, row texts and json local text assets |
| static [AddCustomRequestHandlers](ServiceCollectionExtensions/AddCustomRequestHandlers.md)(…) | Registers all the custom request handlers implementing IRequestHandler interface, from the type source in the service collection if available, or using the provided typeSource, optionally filtering handler types via a provided predicate. |
| static [AddJsonTexts](ServiceCollectionExtensions/AddJsonTexts.md)(…) | Adds json texts from file provider and sub path |
| static [AddProxyRequestHandlers](ServiceCollectionExtensions/AddProxyRequestHandlers.md)(…) | Registers proxy activators for the DI container to resolve generic request handler instances like [`ICreateHandler`](../Serenity.Services/ICreateHandler-1.md), [`IListHandler`](../Serenity.Services/IListHandler-1.md) etc. |
| static [AddServiceBehaviors](ServiceCollectionExtensions/AddServiceBehaviors.md)(…) | Registers default implementations of [`IBehaviorFactory`](../Serenity.Services/IBehaviorFactory.md), [`IImplicitBehaviorRegistry`](../Serenity.Services/IImplicitBehaviorRegistry.md) and [`IBehaviorProvider`](../Serenity.Services/IBehaviorProvider.md) |
| static [AddServiceHandlerFactory](ServiceCollectionExtensions/AddServiceHandlerFactory.md)(…) | Registers default implementations of [`IHandlerActivator`](../Serenity.Services/IHandlerActivator.md), [`IDefaultHandlerFactory`](../Serenity.Services/IDefaultHandlerFactory.md) and [`IDefaultHandlerRegistry`](../Serenity.Services/IDefaultHandlerRegistry.md) |
| static [AddServiceHandlers](ServiceCollectionExtensions/AddServiceHandlers.md)(…) | Registers all the services required for request handlers |

## See Also

* **Source:** *[ServiceCollectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Helpers/ServiceCollectionExtensions.cs)*