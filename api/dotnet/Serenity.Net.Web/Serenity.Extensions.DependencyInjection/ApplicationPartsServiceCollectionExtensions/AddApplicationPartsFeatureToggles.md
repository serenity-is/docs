# ApplicationPartsServiceCollectionExtensions.AddApplicationPartsFeatureToggles method

Adds the IFeatureToggles service to the registry, scanning for FeatureKeySetAttribute in application parts and disabling by default features that have a `[DefaultValue(false)]` attribute. Note that this also calls `AddMvcCore()` to get the part manager if it is not provided and not found in the collection.

```csharp
public static IServiceCollection AddApplicationPartsFeatureToggles(
    this IServiceCollection services, IConfiguration configuration, 
    ApplicationPartManager? applicationPartManager = null, object[]? disableByDefault = null, 
    Dictionary<string, List<RequiresFeatureAttribute>>? dependencyMap = null, 
    bool tryPartRecovery = true, IEnumerable<string>? knownFeatures = null, 
    bool disableUnknown = false, Action<string>? onUnknownFeature = null)
```

| parameter | description |
| --- | --- |
| services | The services. |
| configuration | The configuration source. |
| applicationPartManager | Optional application part manager to use. |
| disableByDefault | Features to disable by default; pass `["*"]` to disable all features by default. |
| dependencyMap | Feature dependency map. Features are dictionary keys and the list of features that they depend on (all must be enabled) for that feature to be enabled. |
| tryPartRecovery | Whether to try recovering application parts when they were not discovered at build time. Defaults to `true`. |
| knownFeatures | Additional known feature keys, e.g. ones used by RequiresFeatureAttribute that are not declared by a FeatureKeySetAttribute enum. These are merged with the ones found by the scan, so they are not reported as unknown and are enabled by default. |
| disableUnknown | Whether to disable unknown feature keys, i.e. the ones that are not declared in a scanned FeatureKeySetAttribute enum, not in the dependency map, not disabled by default and not set in the configuration. Defaults to `false`, which only reports them and keeps them enabled. The Serene and StartSharp templates pass `true`. |
| onUnknownFeature | Callback that is invoked once for each feature key that is queried but not declared anywhere. Defaults to logging a warning. |

## Return Value

The same service collection so that calls can be chained.

## Remarks

The scanned FeatureKeySetAttribute members are also used as the known features, so a feature key that is not declared anywhere is reported through *onUnknownFeature*, and disabled if *disableUnknown* is `true`. A key that is only referenced as a dependency by a RequiresFeatureAttribute is not a declaration, so it is unknown too, and disables the features that depend on it when *disableUnknown* is `true`: declare it in a FeatureKeySetAttribute enum, pass it in *knownFeatures*, or set it in the configuration.

Disabling unknown keys can break existing applications that use string feature keys without declaring them, so it is opt-in. Review the logged feature keys first, then pass `disableUnknown: true` to catch typos in feature keys.

## See Also

* class [RequiresFeatureAttribute](../../../Serenity.Net.Core/Serenity.ComponentModel/RequiresFeatureAttribute.md)
* class [ApplicationPartsServiceCollectionExtensions](../ApplicationPartsServiceCollectionExtensions.md)