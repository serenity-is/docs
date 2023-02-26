# WKHtmlToPdf class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

HTML to PDF converter class using WKHTMLToPdf

```csharp
public class WKHtmlToPdf : IHtmlToPdfOptions
```

## Public Members

| name | description |
| --- | --- |
| [WKHtmlToPdf](WKHtmlToPdf/WKHtmlToPdf.md)(…) | WKHtmlToPdf converter class |
| [AdditionalUrls](WKHtmlToPdf/AdditionalUrls.md) { get; } |  |
| [AllowedLocalPaths](WKHtmlToPdf/AllowedLocalPaths.md) { get; } |  |
| [Cookies](WKHtmlToPdf/Cookies.md) { get; } |  |
| [CustomArgs](WKHtmlToPdf/CustomArgs.md) { get; } |  |
| [DisableLocalFileAccess](WKHtmlToPdf/DisableLocalFileAccess.md) { get; set; } |  |
| [Dpi](WKHtmlToPdf/Dpi.md) { get; set; } |  |
| [ExecutablePath](WKHtmlToPdf/ExecutablePath.md) { get; set; } | Path to the wkhtmltopdf executable |
| [FooterHeaderReplace](WKHtmlToPdf/FooterHeaderReplace.md) { get; } |  |
| [FooterHtmlUrl](WKHtmlToPdf/FooterHtmlUrl.md) { get; set; } |  |
| [HeaderHtmlUrl](WKHtmlToPdf/HeaderHtmlUrl.md) { get; set; } |  |
| [Landscape](WKHtmlToPdf/Landscape.md) { get; set; } |  |
| [MarginBottom](WKHtmlToPdf/MarginBottom.md) { get; set; } |  |
| [MarginLeft](WKHtmlToPdf/MarginLeft.md) { get; set; } |  |
| [MarginRight](WKHtmlToPdf/MarginRight.md) { get; set; } |  |
| [MarginsAll](WKHtmlToPdf/MarginsAll.md) { set; } |  |
| [MarginTop](WKHtmlToPdf/MarginTop.md) { get; set; } |  |
| [PageHeight](WKHtmlToPdf/PageHeight.md) { get; set; } |  |
| [PageSize](WKHtmlToPdf/PageSize.md) { get; set; } |  |
| [PageWidth](WKHtmlToPdf/PageWidth.md) { get; set; } |  |
| [PrintBackground](WKHtmlToPdf/PrintBackground.md) { get; set; } |  |
| [SmartShrinking](WKHtmlToPdf/SmartShrinking.md) { get; set; } |  |
| [TimeoutSeconds](WKHtmlToPdf/TimeoutSeconds.md) { get; set; } |  |
| [Url](WKHtmlToPdf/Url.md) { get; set; } |  |
| [UsePrintMediaType](WKHtmlToPdf/UsePrintMediaType.md) { get; set; } |  |
| [Zoom](WKHtmlToPdf/Zoom.md) { get; set; } |  |
| [Execute](WKHtmlToPdf/Execute.md)() | Executes the converter process and returns the PDF bytes |

## See Also

* interface [IHtmlToPdfOptions](../Serenity.Net.Services/IHtmlToPdfOptions.md)
* **Source:** *[WKHtmlToPdf.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Reporting/WKHtmlToPdf.cs)*