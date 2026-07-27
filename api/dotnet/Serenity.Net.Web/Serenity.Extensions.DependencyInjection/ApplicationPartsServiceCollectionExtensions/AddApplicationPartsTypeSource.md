# ApplicationPartsServiceCollectionExtensions.AddApplicationPartsTypeSource method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Adds an application part type source to the service collection. Note that this also calls AddMvcCore() to get the part manager if not provided, and is not found in the collection.

```csharp
public static ApplicationPartsTypeSource AddApplicationPartsTypeSource(
    this IServiceCollection collection, ApplicationPartManager partManager = null, 
    IFeatureToggles featureToggles = null, bool topologicalSort = true)
```

| parameter | description |
| --- | --- |
| collection | Collection |
| partManager | ApplicationPartManager instance. |
| featureToggles | Feature toggles |
| topologicalSort | Whether to sort assemblies topologically by references |

## See Also

* class [ApplicationPartsTypeSource](../../Serenity.Web/ApplicationPartsTypeSource.md)
* interface [IFeatureToggles](../Serenity.Net.Core/../../Serenity.Abstractions/IFeatureToggles.md)
* class [ApplicationPartsServiceCollectionExtensions](../ApplicationPartsServiceCollectionExtensions.md)