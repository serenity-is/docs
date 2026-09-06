# CssClassAttribute constructor

Sets the CSS class for columns and form fields. In forms, the class is added to the container div with the .field class that contains both label and editor. For columns, it sets the cssClass property of SlickColumn, which adds this class to the slick cells for all rows. Slick column headers are not affected by this attribute, use HeaderCssClass for that.

```csharp
public CssClassAttribute(string? cssClass)
```

| parameter | description |
| --- | --- |
| cssClass | The CSS class. |

## Remarks

Initializes a new instance of the [`CssClassAttribute`](../CssClassAttribute.md) class.

## See Also

* class [CssClassAttribute](../CssClassAttribute.md)