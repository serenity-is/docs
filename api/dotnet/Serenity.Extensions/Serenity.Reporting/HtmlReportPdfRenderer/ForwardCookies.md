# HtmlReportPdfRenderer.ForwardCookies method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Forwards the cookies from the render URL to the converter options.

```csharp
protected virtual void ForwardCookies(IReport report, ReportRenderOptions renderOptions, 
    IHtmlToPdfOptions converterOptions, HtmlReportRenderUrl renderUrl)
```

| parameter | description |
| --- | --- |
| report | The report. |
| renderOptions | The render options. |
| converterOptions | The converter options. |
| renderUrl | The render URL. |

## See Also

* interface [IReport](../Serenity.Net.Services/../IReport.md)
* class [ReportRenderOptions](../Serenity.Net.Services/../ReportRenderOptions.md)
* interface [IHtmlToPdfOptions](../Serenity.Net.Services/../IHtmlToPdfOptions.md)
* class [HtmlReportRenderUrl](../Serenity.Net.Services/../HtmlReportRenderUrl.md)
* class [HtmlReportPdfRenderer](../HtmlReportPdfRenderer.md)