# ServiceCollectionExtensions.AddCustomRequestHandlers method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public static IServiceCollection AddCustomRequestHandlers(this IServiceCollection collection, 
    ITypeSource typeSource = null, Func<Type, Type, bool> predicate = null)
```

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)