# CssClassAttribute constructor
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Sets the CSS class for columns and form fields. In forms, class is added to container div with .field class that contains both label and editor. For columns, it sets cssClass property of SlickColumn, which adds this class to slick cells for all rows. Slick column headers are not affected by this attribute, use HeaderCssClass for that.

```csharp
public CssClassAttribute(string cssClass)
```

| parameter | description |
| --- | --- |
| cssClass | The CSS class. |

## Remarks

Initializes a new instance of the [`CssClassAttribute`](../CssClassAttribute.md) class.

## See Also

* class [CssClassAttribute](../CssClassAttribute.md)