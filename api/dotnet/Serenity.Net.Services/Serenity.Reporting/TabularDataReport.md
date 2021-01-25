# TabularDataReport class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class TabularDataReport : IDataOnlyReport
```

## Public Members

| name | description |
| --- | --- |
| [TabularDataReport](TabularDataReport/TabularDataReport.md)(…) |  (3 constructors) |
| virtual [GetColumnList](TabularDataReport/GetColumnList.md)() |  |
| virtual [GetData](TabularDataReport/GetData.md)() |  |
| const [CacheGroupKey](TabularDataReport/CacheGroupKey.md) |  |
| static [FromPropertyItem](TabularDataReport/FromPropertyItem.md)(…) |  |
| static [GetColumnListFor](TabularDataReport/GetColumnListFor.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [TabularDataReport](TabularDataReport/TabularDataReport.md)() | The default constructor. |
| [ColumnList](TabularDataReport/ColumnList.md) { get; set; } |  |
| [ColumnsType](TabularDataReport/ColumnsType.md) { get; set; } |  |
| [Data](TabularDataReport/Data.md) { get; set; } |  |
| [ExportColumns](TabularDataReport/ExportColumns.md) { get; set; } |  |
| [ServiceProvider](TabularDataReport/ServiceProvider.md) { get; set; } |  |

## See Also

* interface [IDataOnlyReport](IDataOnlyReport.md)
* **Source:** *[TabularDataReport.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/TabularDataReport.cs)*