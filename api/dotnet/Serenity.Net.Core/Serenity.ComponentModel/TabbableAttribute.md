# TabbableAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates if a column is tabbable when enableCellNavigation is true in a grid. By default, all columns are tabbable, but you can set this attribute to false to prevent it from being tabbable. Note that if a column has [Focusable(false)], it won't be tabbable even if it has [Tabbable(true)], because focusable is checked first. This attribute is useful when you want to have a column that can be focused when clicked or with arrow and home/end keys, but not when tabbing through cells. It is similar to having tabindex=-1 on an input.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class TabbableAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | if set to `true` (default) column is tabbable. |

## Public Members

| name | description |
| --- | --- |
| [TabbableAttribute](TabbableAttribute/TabbableAttribute.md)(…) | Indicates if a column is tabbable when enableCellNavigation is true in a grid. By default, all columns are tabbable, but you can set this attribute to false to prevent it from being tabbable. Note that if a column has [Focusable(false)], it won't be tabbable even if it has [Tabbable(true)], because focusable is checked first. This attribute is useful when you want to have a column that can be focused when clicked or with arrow and home/end keys, but not when tabbing through cells. It is similar to having tabindex=-1 on an input. |
| [Value](TabbableAttribute/Value.md) { get; } | Gets a value indicating whether this [`TabbableAttribute`](TabbableAttribute.md) is enabled. |

## Remarks

Initializes a new instance of the [`TabbableAttribute`](TabbableAttribute.md) class.

## See Also

* **Source:** *[TabbableAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/TabbableAttribute.cs)*