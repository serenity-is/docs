# ReportFactoryExtensions.Create&lt;TReport&gt; method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a report for the given report type

```csharp
public static TReport Create<TReport>(this IReportFactory factory, 
    Action<TReport> setParams = null, bool validatePermission = true)
    where TReport : IReport
```

| parameter | description |
| --- | --- |
| TReport | Report type |
| factory | Report factory |
| setParams | Optional callback to initialize params |
| validatePermission | True if the permission for the report should be validated |

## Return Value

Report instance

## See Also

* class [TReport](../Serenity.Net.Services/../ReportFactoryExtensions.TReport.md)
* interface [IReportFactory](../IReportFactory.md)
* interface [IReport](../IReport.md)
* class [ReportFactoryExtensions](../ReportFactoryExtensions.md)