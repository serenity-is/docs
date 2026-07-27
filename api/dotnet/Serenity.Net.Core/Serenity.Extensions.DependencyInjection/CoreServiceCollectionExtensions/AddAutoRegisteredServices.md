# CoreServiceCollectionExtensions.AddAutoRegisteredServices method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Registers all the types with an RegisterService attribute (RegisterSingleton, RegisterScoped, RegisterTransient etc.) from the type source in the service collection if available, or using the provided typeSource, optionally filtering implementation types via a provided predicate. Use this at the end of InitializeServices in Startup.cs so that services can be overridden before others.

```csharp
public static IServiceCollection AddAutoRegisteredServices(this IServiceCollection collection, 
    ITypeSource typeSource = null, 
    Func<Type, Type, RegisterServiceAttribute, bool> predicate = null)
```

| parameter | description |
| --- | --- |
| collection | Service collection |
| typeSource | Type source. Should be provided if it is not already registered in the service collection. Pass an empty type source if you want to disable auto registrations. |
| predicate | Predicate to filter implementation types to register. The first argument is registration type (the interface or the implementation type itself), and the second argument is the implementation type (e.g. the concrete type), and third argument is the registration attribute. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | collection is null or typeSource can't be found in the collection |

## See Also

* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [RegisterServiceAttribute](../../Serenity.ComponentModel/RegisterServiceAttribute.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)