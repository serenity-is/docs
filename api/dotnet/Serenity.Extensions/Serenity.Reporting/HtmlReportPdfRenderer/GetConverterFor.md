# HtmlReportPdfRenderer.GetConverterFor method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Gets the converter to use for the specified report, preferring the WKHtmlToPdf converter when the report is marked with UseWKHtmlToPdfAttribute.

```csharp
protected virtual IHtmlToPdfConverter GetConverterFor(IReport report, 
    ReportRenderOptions renderOptions)
```

| parameter | description |
| --- | --- |
| report | The report. |
| renderOptions | The render options. |

## See Also

* interface [IHtmlToPdfConverter](../Serenity.Net.Services/../IHtmlToPdfConverter.md)
* interface [IReport](../Serenity.Net.Services/../IReport.md)
* class [ReportRenderOptions](../Serenity.Net.Services/../ReportRenderOptions.md)
* class [HtmlReportPdfRenderer](../HtmlReportPdfRenderer.md)