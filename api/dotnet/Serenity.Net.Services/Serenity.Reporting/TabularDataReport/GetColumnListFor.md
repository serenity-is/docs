# TabularDataReport.GetColumnListFor method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Extracts report columns from a columns type

```csharp
public static List<ReportColumn> GetColumnListFor(Type columnsType, 
    IEnumerable<string> exportColumns, IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| columnsType | The columns type |
| exportColumns | The list of column property names to export |
| serviceProvider | Service provider |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | columnsType or serviceProvider is null |

## See Also

* class [ReportColumn](../ReportColumn.md)
* class [TabularDataReport](../TabularDataReport.md)