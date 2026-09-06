# DefaultReportRenderer.RenderExternalReport method

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

* class [ReportRenderResult](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderResult.md)
* interface [IExternalReport](../../../Serenity.Net.Services/Serenity.Reporting/IExternalReport.md)
* class [ReportRenderOptions](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderOptions.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)