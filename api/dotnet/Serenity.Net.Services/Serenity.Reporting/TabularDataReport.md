# TabularDataReport class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An implementation of a data only report which is used mainly for Excel export.

```csharp
public class TabularDataReport : IDataOnlyReport
```

## Public Members

| name | description |
| --- | --- |
| [TabularDataReport](TabularDataReport/TabularDataReport.md)(…) | Initializes a new instance of the class with the given data and report columns. (3 constructors) |
| virtual [GetColumnList](TabularDataReport/GetColumnList.md)() |  |
| virtual [GetData](TabularDataReport/GetData.md)() |  |
| const [CacheGroupKey](TabularDataReport/CacheGroupKey.md) | A group key for caching. |
| static [FromPropertyItem](TabularDataReport/FromPropertyItem.md)(…) | Creates a [`ReportColumn`](ReportColumn.md) from a PropertyItem |
| static [GetColumnListFor](TabularDataReport/GetColumnListFor.md)(…) | Extracts report columns from a columns type |

## Protected Members

| name | description |
| --- | --- |
| [TabularDataReport](TabularDataReport/TabularDataReport.md)() | Initializes a new instance of the class. |
| [ColumnList](TabularDataReport/ColumnList.md) { get; set; } | The column list |
| [ColumnsType](TabularDataReport/ColumnsType.md) { get; set; } | Columns type to use for export. This is used to determine the list of columns and their formats, decorator types etc. |
| [Data](TabularDataReport/Data.md) { get; set; } | The report data |
| [ExportColumns](TabularDataReport/ExportColumns.md) { get; set; } | List of columns to export. If [`ColumnsType`](TabularDataReport/ColumnsType.md) or [`ColumnList`](TabularDataReport/ColumnList.md) is passed this is used to subset the columns. Otherwise it contains the list of columns to export. |
| [ServiceProvider](TabularDataReport/ServiceProvider.md) { get; set; } | Service provider. |

## See Also

* interface [IDataOnlyReport](IDataOnlyReport.md)
* **Source:** *[TabularDataReport.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Reporting/DataReport/TabularDataReport.cs)*