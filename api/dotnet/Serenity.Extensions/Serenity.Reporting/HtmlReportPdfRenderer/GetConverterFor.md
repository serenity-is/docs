# HtmlReportPdfRenderer.GetConverterFor method

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

* interface [IHtmlToPdfConverter](../../../Serenity.Net.Services/Serenity.Reporting/IHtmlToPdfConverter.md)
* interface [IReport](../../../Serenity.Net.Services/Serenity.Reporting/IReport.md)
* class [ReportRenderOptions](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderOptions.md)
* class [HtmlReportPdfRenderer](../HtmlReportPdfRenderer.md)