# DefaultReportRenderer.RenderExternalReport method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Renders an external report, generally returns a ReportRenderResult with a redirect URI.

```csharp
protected virtual ReportRenderResult RenderExternalReport(IExternalReport report, 
    ReportRenderOptions options)
```

| parameter | description |
| --- | --- |
| report | The report. |
| options | The options. |

## Return Value

The render result.

## See Also

* class [ReportRenderResult](../Serenity.Net.Services/../ReportRenderResult.md)
* interface [IExternalReport](../Serenity.Net.Services/../IExternalReport.md)
* class [ReportRenderOptions](../Serenity.Net.Services/../ReportRenderOptions.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)