# HtmlReportPdfRenderer.GetConverterOptions method

Gets the converter options for the specified report, building the render URL and forwarding cookies.

```csharp
protected virtual IHtmlToPdfOptions GetConverterOptions(IReport report, 
    ReportRenderOptions renderOptions, out HtmlReportRenderUrl renderUrl)
```

| parameter | description |
| --- | --- |
| report | The report. |
| renderOptions | The render options. |
| renderUrl | The render URL created for the report. |

## See Also

* interface [IHtmlToPdfOptions](../../../Serenity.Net.Services/Serenity.Reporting/IHtmlToPdfOptions.md)
* interface [IReport](../../../Serenity.Net.Services/Serenity.Reporting/IReport.md)
* class [ReportRenderOptions](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderOptions.md)
* class [HtmlReportRenderUrl](../../../Serenity.Net.Services/Serenity.Reporting/HtmlReportRenderUrl.md)
* class [HtmlReportPdfRenderer](../HtmlReportPdfRenderer.md)