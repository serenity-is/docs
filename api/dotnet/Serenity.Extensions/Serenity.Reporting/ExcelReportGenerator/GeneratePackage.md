# ExcelReportGenerator.GeneratePackage method

Generates an Excel workbook from the specified columns and rows.

```csharp
public static XLWorkbook GeneratePackage(List<ReportColumn> columns, IList rows, 
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

The generated Excel workbook.

## See Also

* class [ReportColumn](../../../Serenity.Net.Services/Serenity.Reporting/ReportColumn.md)
* class [ExcelReportGenerator](../ExcelReportGenerator.md)