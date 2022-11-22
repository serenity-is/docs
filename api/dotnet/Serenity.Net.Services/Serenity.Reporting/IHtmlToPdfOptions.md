# IHtmlToPdfOptions interface
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public interface IHtmlToPdfOptions
```

## Members

| name | description |
| --- | --- |
| [AdditionalUrls](IHtmlToPdfOptions/AdditionalUrls.md) { get; } | Optional list of URLs that should be converted and appended to the document |
| [Cookies](IHtmlToPdfOptions/Cookies.md) { get; } | Contains cookies that will be sent to target URL |
| [CustomArgs](IHtmlToPdfOptions/CustomArgs.md) { get; } | A list of custom arguments to pass to HTML to PDF converter |
| [Dpi](IHtmlToPdfOptions/Dpi.md) { get; set; } | Document DPI. Default is unspecified. |
| [FooterHeaderReplace](IHtmlToPdfOptions/FooterHeaderReplace.md) { get; } | A set of key value pairs that should be search replaced in footer and header |
| [FooterHtmlUrl](IHtmlToPdfOptions/FooterHtmlUrl.md) { get; set; } | Url of footer HTML page |
| [HeaderHtmlUrl](IHtmlToPdfOptions/HeaderHtmlUrl.md) { get; set; } | Url of header HTML page |
| [Landscape](IHtmlToPdfOptions/Landscape.md) { get; set; } | Landscape page layout. Default is false. |
| [MarginBottom](IHtmlToPdfOptions/MarginBottom.md) { get; set; } | Page bottom margin, default is unspecified. |
| [MarginLeft](IHtmlToPdfOptions/MarginLeft.md) { get; set; } | Page left margin, default is unspecified. |
| [MarginRight](IHtmlToPdfOptions/MarginRight.md) { get; set; } | Page right margin, default is unspecified. |
| [MarginsAll](IHtmlToPdfOptions/MarginsAll.md) { set; } | Use this to set all margins (left, right, bottom, top) at once |
| [MarginTop](IHtmlToPdfOptions/MarginTop.md) { get; set; } | Page top margin, default is unspecified. |
| [PageHeight](IHtmlToPdfOptions/PageHeight.md) { get; set; } | Page height like 15cm. Default value is unspecified. |
| [PageSize](IHtmlToPdfOptions/PageSize.md) { get; set; } | Page size constant like "A4", "Letter" etc. Default value is A4 |
| [PageWidth](IHtmlToPdfOptions/PageWidth.md) { get; set; } | Page width like 21cm. Default value is unspecified. |
| [PrintBackground](IHtmlToPdfOptions/PrintBackground.md) { get; set; } | Print background image if any (default true) |
| [SmartShrinking](IHtmlToPdfOptions/SmartShrinking.md) { get; set; } | Use smart shrinking. Default is false. |
| [TimeoutSeconds](IHtmlToPdfOptions/TimeoutSeconds.md) { get; set; } | Timeout for converter in seconds (default 300 seconds / 5 min) |
| [Url](IHtmlToPdfOptions/Url.md) { get; set; } | The URL that is being converted |
| [UsePrintMediaType](IHtmlToPdfOptions/UsePrintMediaType.md) { get; set; } | Use Print media type to render document (default true) |
| [UtilityExePath](IHtmlToPdfOptions/UtilityExePath.md) { get; set; } | Path of wkhtmltopdf.exe, ~/App_Data/Reporting/wkhtmltopdf.exe if not specified |
| [Zoom](IHtmlToPdfOptions/Zoom.md) { get; set; } | Zoom value like "0.33". Default is unspecified. |

## See Also

* **Source:** *[IHtmlToPdfOptions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/IHtmlToPdfOptions.cs)*