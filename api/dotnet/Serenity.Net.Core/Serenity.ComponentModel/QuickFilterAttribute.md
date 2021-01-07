# QuickFilterAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this property should have a quick filter on grid.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class QuickFilterAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [QuickFilterAttribute](QuickFilterAttribute/QuickFilterAttribute.md)(…) | Initializes a new instance of the [`QuickFilterAttribute`](QuickFilterAttribute.md) class. |
| [CssClass](QuickFilterAttribute/CssClass.md) { get; set; } | Gets or sets the CSS class for generated quick filter div. |
| [Separator](QuickFilterAttribute/Separator.md) { get; set; } | Gets or sets a value indicating whether this [`QuickFilterAttribute`](QuickFilterAttribute.md) should have a separator before others, e.g. wrap into new line. |
| [Value](QuickFilterAttribute/Value.md) { get; } | Gets a value indicating whether this [`QuickFilterAttribute`](QuickFilterAttribute.md) is enabled. |

## See Also

* **Source:** *[QuickFilterAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Filtering/QuickFilterAttribute.cs)*