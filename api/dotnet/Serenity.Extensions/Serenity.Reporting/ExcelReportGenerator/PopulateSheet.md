# ExcelReportGenerator.PopulateSheet method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Populates the specified worksheet with the given columns and rows.

```csharp
public static void PopulateSheet(IXLWorksheet worksheet, List<ReportColumn> columns, IList rows, 
    string tableName = "Table1", XLTableTheme tableStyle = null, int startRow = 1, 
    int startCol = 1, int autoFitRows = 250)
```

| parameter | description |
| --- | --- |
| worksheet | The worksheet to populate. |
| columns | The report columns. |
| rows | The data rows. |
| tableName | The table name. |
| tableStyle | The table theme. |
| startRow | The starting row. |
| startCol | The starting column. |
| autoFitRows | The number of rows to auto-fit. |

## See Also

* class [ReportColumn](../Serenity.Net.Services/../ReportColumn.md)
* class [ExcelReportGenerator](../ExcelReportGenerator.md)