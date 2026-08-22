# RequiresElevationAttribute class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Used for critical methods that needs additional authentication. Like account link/unlinking.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class RequiresElevationAttribute : Attribute, IResourceFilter
```

## Public Members

| name | description |
| --- | --- |
| [RequiresElevationAttribute](RequiresElevationAttribute/RequiresElevationAttribute.md)() | The default constructor. |
| [OnResourceExecuted](RequiresElevationAttribute/OnResourceExecuted.md)(…) |  |
| [OnResourceExecuting](RequiresElevationAttribute/OnResourceExecuting.md)(…) |  |

## See Also

* **Source:** *[RequiresElevationAttribute.cs](https://github.com/serenity-is/Serenity/blob/72b12ffb07e0792856320c825701db0522a3894b/common-features/src/extensions/Modules/Elevation/RequiresElevationAttribute.cs)*