# ExcelReportGenerator.AsObject method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Converts the specified XLCellValue to its corresponding .NET object.

```csharp
public static object AsObject(this XLCellValue value)
```

| parameter | description |
| --- | --- |
| value | The cell value to convert. |

## Return Value

The converted object, or `null` for a blank cell.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidCastException | The cell value type is not supported. |

## See Also

* class [ExcelReportGenerator](../ExcelReportGenerator.md)