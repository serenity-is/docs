# ConfigurationFeatureToggles constructor

Default implementation for IFeatureToggles that reads from configuration's FeatureToggles section. Unless the value is explicitly set to "false" for a feature, it is considered enabled. When *knownFeatures* is passed, features that are not declared anywhere are considered unknown, and reported through [`UnknownFeatures`](./UnknownFeatures.md). They are also disabled when *disableUnknown* is `true`.

```csharp
public ConfigurationFeatureToggles(IConfiguration configuration, object[]? disableByDefault = null, 
    Dictionary<string, List<RequiresFeatureAttribute>>? dependencyMap = null, 
    IEnumerable<string>? knownFeatures = null, bool disableUnknown = false, 
    Action<string>? onUnknownFeature = null)
```

| parameter | description |
| --- | --- |
| configuration | Configuration |
| disableByDefault | Features to disable by default |
| dependencyMap | Feature dependency map. Features are dictionary keys and the list of features that they depend on (e.g. all must be enabled) for that feature to be enabled. |
| knownFeatures | Known feature keys, e.g. the members of the enums annotated with `FeatureKeySetAttribute`. When this is not `null`, a feature that is not declared anywhere is considered an unknown feature, and disabled if *disableUnknown* is `true`. Pass `null` when the known features cannot be determined, which keeps the behavior where every feature is enabled by default. |
| disableUnknown | Whether to disable unknown features, i.e. ones that are not declared anywhere. Defaults to `false`, which only reports them through [`UnknownFeatures`](./UnknownFeatures.md) and *onUnknownFeature* while keeping them enabled, e.g. to review them in an existing installation. Pass `true` to disable them. It only has an effect when *knownFeatures* is not `null`. |
| onUnknownFeature | Callback that is invoked once for each feature key that is queried but not declared anywhere, e.g. to log it. |

## Remarks

Feature names are matched case insensitively, like the configuration keys. A feature is considered declared when it is in *knownFeatures*, in *disableByDefault*, in *dependencyMap*, or when it appears in the configuration, even if its value cannot be parsed. Note that only the feature keys themselves are declarations, so a key that is merely referenced by a `RequiresFeatureAttribute` as a dependency is still unknown unless it is declared.

## See Also

* class [RequiresFeatureAttribute](../../Serenity.ComponentModel/RequiresFeatureAttribute.md)
* class [ConfigurationFeatureToggles](../ConfigurationFeatureToggles.md)