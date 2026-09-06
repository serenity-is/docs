# ApplicationPartsServiceCollectionExtensions.AddApplicationPartsTypeSource method

Adds an application part type source to the service collection. Note that this also calls `AddMvcCore()` to get the part manager if it is not provided and not found in the collection.

```csharp
public static ApplicationPartsTypeSource AddApplicationPartsTypeSource(
    this IServiceCollection collection, ApplicationPartManager partManager = null, 
    IFeatureToggles featureToggles = null, bool topologicalSort = true)
```

| parameter | description |
| --- | --- |
| collection | The service collection. |
| partManager | The ApplicationPartManager instance. |
| featureToggles | The feature toggles. |
| topologicalSort | Whether to sort assemblies topologically by references. |

## Return Value

The created [`ApplicationPartsTypeSource`](../../Serenity.Web/ApplicationPartsTypeSource.md).

## See Also

* class [ApplicationPartsTypeSource](../../Serenity.Web/ApplicationPartsTypeSource.md)
* interface [IFeatureToggles](../../../Serenity.Net.Core/Serenity.Abstractions/IFeatureToggles.md)
* class [ApplicationPartsServiceCollectionExtensions](../ApplicationPartsServiceCollectionExtensions.md)