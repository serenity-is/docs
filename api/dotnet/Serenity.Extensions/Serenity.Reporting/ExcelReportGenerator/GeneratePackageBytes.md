# ExcelReportGenerator.GeneratePackageBytes method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Generates an Excel package as bytes from the specified columns and rows.

```csharp
public static byte[] GeneratePackageBytes(List<ReportColumn> columns, IList rows, 
    string sheetName = "Page1", string tableName = "Table1", XLTableTheme tableStyle = null, 
    int startRow = 1, int startCol = 1, int autoFitRows = 250)
```

| parameter | description |
| --- | --- |
| columns | The report columns. |
| rows | The data rows. |
| sheetName | The worksheet name. |
| tableName | The table name. |
| tableStyle | The table theme. |
| startRow | The starting row. |
| startCol | The starting column. |
| autoFitRows | The number of rows to auto-fit. |

## Return Value

The generated Excel package bytes.

## See Also

* class [ReportColumn](../Serenity.Net.Services/../ReportColumn.md)
* class [ExcelReportGenerator](../ExcelReportGenerator.md)