# DefaultReportRenderer.RenderAsHtml method

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

* class [ReportRenderResult](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderResult.md)
* interface [IReport](../../../Serenity.Net.Services/Serenity.Reporting/IReport.md)
* class [ReportRenderOptions](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderOptions.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)