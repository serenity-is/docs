# HtmlReportPdfRenderer.GetConverterOptions method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

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

* interface [IHtmlToPdfOptions](../Serenity.Net.Services/../IHtmlToPdfOptions.md)
* interface [IReport](../Serenity.Net.Services/../IReport.md)
* class [ReportRenderOptions](../Serenity.Net.Services/../ReportRenderOptions.md)
* class [HtmlReportRenderUrl](../Serenity.Net.Services/../HtmlReportRenderUrl.md)
* class [HtmlReportPdfRenderer](../HtmlReportPdfRenderer.md)