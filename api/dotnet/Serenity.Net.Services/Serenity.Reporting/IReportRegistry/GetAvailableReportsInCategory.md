# IReportRegistry.GetAvailableReportsInCategory method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets all available reports in category, for example "Northwind". This only returns reports that current user has access to, by checking their permissions if any.

```csharp
public IEnumerable<Report> GetAvailableReportsInCategory(string categoryKey)
```

| parameter | description |
| --- | --- |
| categoryKey | The category key. |

## Return Value

The available reports in that category.

## See Also

* class [Report](../ReportRegistry.Report.md)
* interface [IReportRegistry](../IReportRegistry.md)