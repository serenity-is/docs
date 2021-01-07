# CssClassAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the CSS class for columns and form fields. In forms, class is added to container div with .field class that contains both label and editor. For columns, it sets cssClass property of SlickColumn, which adds this class to slick cells for all rows. Slick column headers are not affected by this attribute, use HeaderCssClass for that.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class CssClassAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [CssClassAttribute](CssClassAttribute/CssClassAttribute.md)(…) | Initializes a new instance of the [`CssClassAttribute`](CssClassAttribute.md) class. |
| [CssClass](CssClassAttribute/CssClass.md) { get; } | Gets the CSS class. |

## See Also

* **Source:** *[CssClassAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/CssClassAttribute.cs)*