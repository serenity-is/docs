# FeatureBarrierAttribute class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An attribute that can be placed on MVC controllers, controller actions, or Razor pages to require all or any of a set of features to be enabled. Note that if no IFeatureToggles service is registered, the feature barrier will always pass.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class FeatureBarrierAttribute : RequiresFeatureAttribute, IActionConstraint, IPageFilter
```

## Public Members

| name | description |
| --- | --- |
| [FeatureBarrierAttribute](FeatureBarrierAttribute/FeatureBarrierAttribute.md)(…) | Creates an attribute that can be used to barrier actions or pages. The barrier can be configured to require all or any of the provided feature(s) to pass. (2 constructors) |
| [Order](FeatureBarrierAttribute/Order.md) { get; } |  |
| [Accept](FeatureBarrierAttribute/Accept.md)(…) |  |
| [OnPageHandlerExecuted](FeatureBarrierAttribute/OnPageHandlerExecuted.md)(…) |  |
| [OnPageHandlerExecuting](FeatureBarrierAttribute/OnPageHandlerExecuting.md)(…) |  |
| [OnPageHandlerSelected](FeatureBarrierAttribute/OnPageHandlerSelected.md)(…) |  |

## See Also

* class [RequiresFeatureAttribute](../Serenity.Net.Core/../Serenity.ComponentModel/RequiresFeatureAttribute.md)
* **Source:** *[FeatureBarrierAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/FeatureBarrierAttribute.cs)*