# ConfigurationFeatureToggles class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default implementation for IFeatureToggles that reads from configuration's FeatureToggles section. Unless the value is explicitly set to "false" for a feature, it is considered enabled.

```csharp
public class ConfigurationFeatureToggles : IFeatureToggles
```

| parameter | description |
| --- | --- |
| configuration | Configuration |
| disableByDefault | Features to disable by default |
| dependencyMap | Feature dependency map. Features are dictionary keys and the list of features that they depend on (e.g. all must be enabled) for that feature to be enabled. |

## Public Members

| name | description |
| --- | --- |
| [ConfigurationFeatureToggles](ConfigurationFeatureToggles/ConfigurationFeatureToggles.md)(…) | Default implementation for IFeatureToggles that reads from configuration's FeatureToggles section. Unless the value is explicitly set to "false" for a feature, it is considered enabled. |
| [IsEnabled](ConfigurationFeatureToggles/IsEnabled.md)(…) |  |

## See Also

* interface [IFeatureToggles](../Serenity.Abstractions/IFeatureToggles.md)
* **Source:** *[ConfigurationFeatureToggles.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/FeatureToggles/ConfigurationFeatureToggles.cs)*