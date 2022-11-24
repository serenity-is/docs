# ServiceCollectionExtensions.AddCustomRequestHandlers method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Registers all the custom request handlers implementing IRequestHandler interface, from the type source in the service collection if available, or using the provided typeSource, optionally filtering handler types via a provided predicate.

```csharp
public static IServiceCollection AddCustomRequestHandlers(this IServiceCollection collection, 
    ITypeSource typeSource = null, Func<Type, Type, bool> predicate = null)
```

| parameter | description |
| --- | --- |
| collection | Service collection |
| typeSource | Type source. Should be provided if it is not already registered in the service collection. Pass an empty type source if you want to disable auto registrations. |
| predicate | Predicate to filter handler types to register. The first argument is registration type (the interface or the handler type itself), and the second argument is the implementation type (e.g. the handler type). If you don't want concrete types like MySaveHandler etc. to be registered for themselves (recommended), the predicate should be "(intf, impl) =&gt; intf != impl" |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | collection is null or typeSource can't be found in the collection |
| InvalidProgramException | Multiple candidates found for a service interface. |

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)