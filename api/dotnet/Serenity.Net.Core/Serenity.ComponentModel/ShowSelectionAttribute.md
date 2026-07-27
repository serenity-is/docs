# ShowSelectionAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Controls whether the CSS class for selected cells (default "selected") is applied to cells in this column when the containing row is selected. By default, the selected CSS class is applied to all columns in a selected row. Set this attribute to false to exclude specific columns from receiving the selected styling. This is useful for columns with custom formatters or styling that don't work well with the selected appearance.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class ShowSelectionAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | if set to `true` (default), the selected CSS class will be applied to cells in this column when the row is selected; otherwise, it will not. |

## Public Members

| name | description |
| --- | --- |
| [ShowSelectionAttribute](ShowSelectionAttribute/ShowSelectionAttribute.md)(…) | Controls whether the CSS class for selected cells (default "selected") is applied to cells in this column when the containing row is selected. By default, the selected CSS class is applied to all columns in a selected row. Set this attribute to false to exclude specific columns from receiving the selected styling. This is useful for columns with custom formatters or styling that don't work well with the selected appearance. |
| [Value](ShowSelectionAttribute/Value.md) { get; } | Gets a value indicating whether the selected CSS class should be applied to cells in this column when the containing row is selected. |

## Remarks

This attribute only affects the visual styling of cells when rows are selected. It does not control whether cells can be navigated to or edited.

## See Also

* **Source:** *[ShowSelectionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/ShowSelectionAttribute.cs)*