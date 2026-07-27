# CoreServiceCollectionExtensions.AddTypeSource method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds a type source to the registry.

```csharp
public static void AddTypeSource(this IServiceCollection services, Assembly[] assemblies, 
    IFeatureToggles featureToggles = null)
```

| parameter | description |
| --- | --- |
| services | The services. |
| assemblies | List of assembles |
| featureToggles | Feature toggles |

## See Also

* interface [IFeatureToggles](../../Serenity.Abstractions/IFeatureToggles.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)