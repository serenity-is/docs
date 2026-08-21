# DefaultReportRenderer.GetViewName method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets the view name for the report.

```csharp
protected virtual string GetViewName(IReport report, ReportRenderOptions options)
```

| parameter | description |
| --- | --- |
| report | The report. |
| options | The options. |

## Return Value

The view name.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | The report has no design attribute. |

## See Also

* interface [IReport](../Serenity.Net.Services/../IReport.md)
* class [ReportRenderOptions](../Serenity.Net.Services/../ReportRenderOptions.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)