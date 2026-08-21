# DefaultReportRenderer.RenderAsHtml method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Renders a report as HTML.

```csharp
protected virtual ReportRenderResult RenderAsHtml(IReport report, ReportRenderOptions options)
```

| parameter | description |
| --- | --- |
| report | The report. |
| options | The options. |

## Return Value

The render result.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | The report has no design attribute. |

## See Also

* class [ReportRenderResult](../Serenity.Net.Services/../ReportRenderResult.md)
* interface [IReport](../Serenity.Net.Services/../IReport.md)
* class [ReportRenderOptions](../Serenity.Net.Services/../ReportRenderOptions.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)