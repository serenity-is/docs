# HtmlReportRenderUrl class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Response type for IHtmlReportRenderUrlBuilder.GetRenderUrl method

```csharp
public class HtmlReportRenderUrl : IDisposable
```

## Public Members

| name | description |
| --- | --- |
| [HtmlReportRenderUrl](HtmlReportRenderUrl/HtmlReportRenderUrl.md)() | Creates a new instance of the class |
| [CookiesToForward](HtmlReportRenderUrl/CookiesToForward.md) { get; } | List of cookies to forward |
| [FooterUrl](HtmlReportRenderUrl/FooterUrl.md) { get; set; } | The generated URL for footer content |
| [HeaderUrl](HtmlReportRenderUrl/HeaderUrl.md) { get; set; } | The generated URL for header content |
| [Url](HtmlReportRenderUrl/Url.md) { get; set; } | The generated URL for main page |
| [Dispose](HtmlReportRenderUrl/Dispose.md)() | Disposes resources |
| virtual [GetTemporaryFolders](HtmlReportRenderUrl/GetTemporaryFolders.md)() | Gets the list of temporary folders if any. This can be used to pass them to WKHTMLTOPDF's --allow argument. |

## Protected Members

| name | description |
| --- | --- |
| virtual [Cleanup](HtmlReportRenderUrl/Cleanup.md)() | Cleanup method that can be overridden by derived classes. |
| override [Finalize](HtmlReportRenderUrl/Finalize.md)() | Finalizer |

## See Also

* **Source:** *[HtmlReportRenderUrl.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/HtmlToPdf/HtmlReportRenderUrl.cs)*