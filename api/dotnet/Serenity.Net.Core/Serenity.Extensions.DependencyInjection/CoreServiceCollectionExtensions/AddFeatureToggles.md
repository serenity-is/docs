# CoreServiceCollectionExtensions.AddFeatureToggles method

Adds the IFeatureToggles service to the registry.

```csharp
public static IServiceCollection AddFeatureToggles(this IServiceCollection services, 
    IConfiguration? configuration = null, object[]? disableByDefault = null, 
    Dictionary<string, List<RequiresFeatureAttribute>>? dependencyMap = null, 
    IEnumerable<string>? knownFeatures = null, bool disableUnknown = false, 
    Action<string>? onUnknownFeature = null)
```

| parameter | description |
| --- | --- |
| services | The services. |
| configuration | Configuration source. |
| disableByDefault | Features to disable by default, pass ["*"] to disable all features by default. |
| dependencyMap | Feature dependency map. Features are dictionary keys and the list of features that they depend on (e.g. all must be enabled) for that feature to be enabled. |
| knownFeatures | Known feature keys, e.g. those declared by the enums annotated with `FeatureKeySetAttribute`. When this is passed, features that are not declared anywhere are treated as unknown, reported through *onUnknownFeature*, and disabled if *disableUnknown* is `true`. Pass `null` (the default) when the known features cannot be determined. |
| disableUnknown | Whether to disable unknown features. Defaults to `false`, and only has an effect when *knownFeatures* is not `null`. |
| onUnknownFeature | Callback that is invoked once for each feature key that is queried but not declared anywhere, e.g. to log it. |

## See Also

* class [RequiresFeatureAttribute](../../Serenity.ComponentModel/RequiresFeatureAttribute.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)