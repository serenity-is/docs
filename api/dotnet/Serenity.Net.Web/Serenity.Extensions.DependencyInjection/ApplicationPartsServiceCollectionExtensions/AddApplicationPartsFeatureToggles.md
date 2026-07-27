# ApplicationPartsServiceCollectionExtensions.AddApplicationPartsFeatureToggles method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Adds IFeatureToggles service to the registry scanning for FeatureKeySetAttribute in application parts, setting disabled by default for features that has a [DefaultValue(false)] attribute. Note that this also calls AddMvcCore() to get the part manager if not provided, and is not found in the collection.

```csharp
public static IServiceCollection AddApplicationPartsFeatureToggles(
    this IServiceCollection services, IConfiguration configuration, 
    ApplicationPartManager applicationPartManager = null, object[] disableByDefault = null, 
    Dictionary<string, List<RequiresFeatureAttribute>> dependencyMap = null)
```

| parameter | description |
| --- | --- |
| services | The services. |
| configuration | Configuration source |
| applicationPartManager | Optional application part manager to use |
| disableByDefault | Features to disable by default, pass ["*"] to disable all features by default |
| dependencyMap | Feature dependency map. Features are dictionary keys and the list of features that they depend on (e.g. all must be enabled) for that feature to be enabled. |

## See Also

* class [RequiresFeatureAttribute](../Serenity.Net.Core/../../Serenity.ComponentModel/RequiresFeatureAttribute.md)
* class [ApplicationPartsServiceCollectionExtensions](../ApplicationPartsServiceCollectionExtensions.md)