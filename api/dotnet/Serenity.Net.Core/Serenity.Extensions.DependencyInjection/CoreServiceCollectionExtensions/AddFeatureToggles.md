# CoreServiceCollectionExtensions.AddFeatureToggles method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds IFeatureToggles service to the registry.

```csharp
public static IServiceCollection AddFeatureToggles(this IServiceCollection services, 
    IConfiguration configuration = null, object[] disableByDefault = null, 
    Dictionary<string, List<RequiresFeatureAttribute>> dependencyMap = null)
```

| parameter | description |
| --- | --- |
| services | The services. |
| configuration | Configuration source |
| disableByDefault | Features to disable by default, pass ["*"] to disable all features by default |
| dependencyMap | Feature dependency map. Features are dictionary keys and the list of features that they depend on (e.g. all must be enabled) for that feature to be enabled. |

## See Also

* class [RequiresFeatureAttribute](../../Serenity.ComponentModel/RequiresFeatureAttribute.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)