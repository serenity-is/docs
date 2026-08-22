# HtmlReportCallbackUrlBuilder class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Default implementation for IHtmlReportRenderUrlBuilder

```csharp
public class HtmlReportCallbackUrlBuilder : IHtmlReportCallbackUrlBuilder
```

## Public Members

| name | description |
| --- | --- |
| [HtmlReportCallbackUrlBuilder](HtmlReportCallbackUrlBuilder/HtmlReportCallbackUrlBuilder.md)(…) | Default implementation for IHtmlReportRenderUrlBuilder |
| virtual [GetRenderUrl](HtmlReportCallbackUrlBuilder/GetRenderUrl.md)(…) | Gets the render URL for the specified report and options. |

## Protected Members

| name | description |
| --- | --- |
| readonly [siteAbsoluteUrl-](HtmlReportCallbackUrlBuilder/siteAbsoluteUrl-.md) | The site absolute URL service used to resolve the internal URL of the web site. |
| virtual [GetAuthCookieName](HtmlReportCallbackUrlBuilder/GetAuthCookieName.md)() | Gets the name of the authentication cookie to forward to the report callback. |
| virtual [GetCookiesToForward](HtmlReportCallbackUrlBuilder/GetCookiesToForward.md)() | Gets the cookies to forward to the report callback, including the report auth cookie and the current request's authentication and language cookies. |
| virtual [GetLanguageCookieName](HtmlReportCallbackUrlBuilder/GetLanguageCookieName.md)() | Gets the name of the language preference cookie to forward to the report callback. |
| virtual [GetRenderAction](HtmlReportCallbackUrlBuilder/GetRenderAction.md)(…) | Gets the render action path for the specified report. |
| virtual [GetReportKey](HtmlReportCallbackUrlBuilder/GetReportKey.md)(…) | Gets the report key for the specified report, using its ReportAttribute key or its full type name. |
| virtual [GetSiteInternalUrl](HtmlReportCallbackUrlBuilder/GetSiteInternalUrl.md)() | Gets the internal URL of the web site used to build the report callback URL. |

## See Also

* interface [IHtmlReportCallbackUrlBuilder](../Serenity.Net.Services/IHtmlReportCallbackUrlBuilder.md)
* **Source:** *[HtmlReportCallbackUrlBuilder.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Reporting/HtmlToPdf/HtmlReportCallbackUrlBuilder.cs)*