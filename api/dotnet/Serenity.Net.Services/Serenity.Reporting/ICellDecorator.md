# ICellDecorator interface
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Cell decorator interface mainly used for Excel export styling.

```csharp
public interface ICellDecorator
```

## Members

| name | description |
| --- | --- |
| [Background](ICellDecorator/Background.md) { get; set; } | Assign to set background color of the current cell |
| [Foreground](ICellDecorator/Foreground.md) { get; set; } | Assign to set text color of the current cell |
| [Format](ICellDecorator/Format.md) { get; set; } | Assign to set display format of the current cell. The format should be in Excel formatting style. |
| [Item](ICellDecorator/Item.md) { get; set; } | The input item |
| [Name](ICellDecorator/Name.md) { get; set; } | The column name |
| [Value](ICellDecorator/Value.md) { get; set; } | Value of the current cell. If desired, it can be modified by the decorator. |
| [Decorate](ICellDecorator/Decorate.md)() | The decorator should apply its formatting in this method. It is called by the exporter. |

## See Also

* **Source:** *[ICellDecorator.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/Decorators/ICellDecorator.cs)*