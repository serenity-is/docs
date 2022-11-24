# ServiceCollectionExtensions.AddServiceHandlers method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Registers all the services required for request handlers

```csharp
public static IServiceCollection AddServiceHandlers(this IServiceCollection collection, 
    ITypeSource customHandlerTypeSource = null, 
    Func<Type, Type, bool> customHandlerPredicate = null)
```

| parameter | description |
| --- | --- |
| collection | Service collection |
| customHandlerTypeSource | Custom handler type source to pass to the AddCustomHandlers call. Pass an empty type source if you want to disable auto registrations |
| customHandlerPredicate | Predicate to filter handler types to register. The first argument is registration type (the interface or the handler type itself), and the second argument is the implementation type (e.g. the handler type). If you don't want concrete types like MySaveHandler etc. to be registered for themselves (recommended), the predicate should be "(intf, impl) =&gt; intf != impl" |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidProgramException | Multiple candidates found for a service interface. |

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)