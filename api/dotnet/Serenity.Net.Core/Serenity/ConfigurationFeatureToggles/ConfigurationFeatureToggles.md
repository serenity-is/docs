# ConfigurationFeatureToggles constructor
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Default implementation for IFeatureToggles that reads from configuration's FeatureToggles section. Unless the value is explicitly set to "false" for a feature, it is considered enabled.

```csharp
public ConfigurationFeatureToggles(IConfiguration configuration, object[] disableByDefault = null, 
    Dictionary<string, List<RequiresFeatureAttribute>> dependencyMap = null)
```

| parameter | description |
| --- | --- |
| configuration | Configuration |
| disableByDefault | Features to disable by default |
| dependencyMap | Feature dependency map. Features are dictionary keys and the list of features that they depend on (e.g. all must be enabled) for that feature to be enabled. |

## See Also

* class [RequiresFeatureAttribute](../../Serenity.ComponentModel/RequiresFeatureAttribute.md)
* class [ConfigurationFeatureToggles](../ConfigurationFeatureToggles.md)