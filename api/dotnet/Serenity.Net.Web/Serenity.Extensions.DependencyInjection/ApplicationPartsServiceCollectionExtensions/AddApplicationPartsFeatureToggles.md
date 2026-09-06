# ApplicationPartsServiceCollectionExtensions.AddApplicationPartsFeatureToggles method

Adds the IFeatureToggles service to the registry, scanning for FeatureKeySetAttribute in application parts and disabling by default features that have a `[DefaultValue(false)]` attribute. Note that this also calls `AddMvcCore()` to get the part manager if it is not provided and not found in the collection.

```csharp
public static IServiceCollection AddApplicationPartsFeatureToggles(
    this IServiceCollection services, IConfiguration configuration, 
    ApplicationPartManager applicationPartManager = null, object[] disableByDefault = null, 
    Dictionary<string, List<RequiresFeatureAttribute>> dependencyMap = null)
```

| parameter | description |
| --- | --- |
| services | The services. |
| configuration | The configuration source. |
| applicationPartManager | Optional application part manager to use. |
| disableByDefault | Features to disable by default; pass `["*"]` to disable all features by default. |
| dependencyMap | Feature dependency map. Features are dictionary keys and the list of features that they depend on (all must be enabled) for that feature to be enabled. |

## Return Value

The same service collection so that calls can be chained.

## See Also

* class [RequiresFeatureAttribute](../../../Serenity.Net.Core/Serenity.ComponentModel/RequiresFeatureAttribute.md)
* class [ApplicationPartsServiceCollectionExtensions](../ApplicationPartsServiceCollectionExtensions.md)