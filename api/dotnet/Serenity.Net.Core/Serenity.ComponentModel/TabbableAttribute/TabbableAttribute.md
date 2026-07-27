# TabbableAttribute constructor
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Indicates if a column is tabbable when enableCellNavigation is true in a grid. By default, all columns are tabbable, but you can set this attribute to false to prevent it from being tabbable. Note that if a column has [Focusable(false)], it won't be tabbable even if it has [Tabbable(true)], because focusable is checked first. This attribute is useful when you want to have a column that can be focused when clicked or with arrow and home/end keys, but not when tabbing through cells. It is similar to having tabindex=-1 on an input.

```csharp
public TabbableAttribute(bool value = true)
```

| parameter | description |
| --- | --- |
| value | if set to `true` (default) column is tabbable. |

## Remarks

Initializes a new instance of the [`TabbableAttribute`](../TabbableAttribute.md) class.

## See Also

* class [TabbableAttribute](../TabbableAttribute.md)