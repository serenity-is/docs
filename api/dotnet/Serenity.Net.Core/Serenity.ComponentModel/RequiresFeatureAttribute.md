# RequiresFeatureAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An attribute that can be placed on targets to toggle them at runtime based features. Use FeatureBarrierAttribute for MVC controllers, controller actions, or Razor pages.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class RequiresFeatureAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [RequiresFeatureAttribute](RequiresFeatureAttribute/RequiresFeatureAttribute.md)(…) | Creates an attribute that can be used to toggle targets. The toggle can be configured to require all or any of the provided feature(s) to pass. (2 constructors) |
| [Features](RequiresFeatureAttribute/Features.md) { get; } | The name of the features that the feature attribute will activate for. |
| [RequireAny](RequiresFeatureAttribute/RequireAny.md) { get; set; } | Controls whether any (true) or all (false, default) features in [`Features`](RequiresFeatureAttribute/Features.md) should be enabled to pass. |

## See Also

* **Source:** *[RequiresFeatureAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/FeatureToggles/RequiresFeatureAttribute.cs)*