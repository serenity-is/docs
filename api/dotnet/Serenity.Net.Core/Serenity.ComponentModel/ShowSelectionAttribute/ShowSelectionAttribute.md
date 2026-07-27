# ShowSelectionAttribute constructor
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Controls whether the CSS class for selected cells (default "selected") is applied to cells in this column when the containing row is selected. By default, the selected CSS class is applied to all columns in a selected row. Set this attribute to false to exclude specific columns from receiving the selected styling. This is useful for columns with custom formatters or styling that don't work well with the selected appearance.

```csharp
public ShowSelectionAttribute(bool value = true)
```

| parameter | description |
| --- | --- |
| value | if set to `true` (default), the selected CSS class will be applied to cells in this column when the row is selected; otherwise, it will not. |

## Remarks

This attribute only affects the visual styling of cells when rows are selected. It does not control whether cells can be navigated to or edited.

## See Also

* class [ShowSelectionAttribute](../ShowSelectionAttribute.md)