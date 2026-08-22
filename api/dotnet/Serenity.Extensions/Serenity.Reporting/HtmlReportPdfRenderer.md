# HtmlReportPdfRenderer class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Default implementation for IHtmlReportPdfRenderer

```csharp
public class HtmlReportPdfRenderer : IHtmlReportPdfRenderer
```

## Public Members

| name | description |
| --- | --- |
| [HtmlReportPdfRenderer](HtmlReportPdfRenderer/HtmlReportPdfRenderer.md)(…) | Default implementation for IHtmlReportPdfRenderer |
| virtual [Render](HtmlReportPdfRenderer/Render.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| readonly [environmentSettings-](HtmlReportPdfRenderer/environmentSettings-.md) | The environment settings used to resolve the internal URL of the web site. |
| readonly [htmlToPdfConverter-](HtmlReportPdfRenderer/htmlToPdfConverter-.md) | The HTML to PDF converter used to render the report. |
| readonly [httpContextAccessor-](HtmlReportPdfRenderer/httpContextAccessor-.md) | The HTTP context accessor used to access the current request. |
| readonly [renderUrlBuilder-](HtmlReportPdfRenderer/renderUrlBuilder-.md) | The render URL builder used to build the report callback URL. |
| readonly [wkHtmlToPdfConverter-](HtmlReportPdfRenderer/wkHtmlToPdfConverter-.md) | The optional WKHtmlToPdf converter used when a report requests it. |
| virtual [ForwardCookies](HtmlReportPdfRenderer/ForwardCookies.md)(…) | Forwards the cookies from the render URL to the converter options. |
| virtual [GetConverterFor](HtmlReportPdfRenderer/GetConverterFor.md)(…) | Gets the converter to use for the specified report, preferring the WKHtmlToPdf converter when the report is marked with UseWKHtmlToPdfAttribute. |
| virtual [GetConverterOptions](HtmlReportPdfRenderer/GetConverterOptions.md)(…) | Gets the converter options for the specified report, building the render URL and forwarding cookies. |

## See Also

* interface [IHtmlReportPdfRenderer](../Serenity.Net.Services/IHtmlReportPdfRenderer.md)
* **Source:** *[HtmlReportPdfRenderer.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Reporting/HtmlToPdf/HtmlReportPdfRenderer.cs)*