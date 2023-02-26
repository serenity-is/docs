# DefaultReportRenderer class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation for IReportRenderer

```csharp
public class DefaultReportRenderer : IReportRenderer
```

## Public Members

| name | description |
| --- | --- |
| [DefaultReportRenderer](DefaultReportRenderer/DefaultReportRenderer.md)(…) | Creates an instance of the class |
| [Render](DefaultReportRenderer/Render.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| readonly [excelRenderer-](DefaultReportRenderer/excelRenderer-.md) | Excel renderer |
| readonly [htmlReportPdfRenderer-](DefaultReportRenderer/htmlReportPdfRenderer-.md) | Html report pdf renderer |
| readonly [httpContextAccessor-](DefaultReportRenderer/httpContextAccessor-.md) | Http context accessor |
| readonly [serviceProvider-](DefaultReportRenderer/serviceProvider-.md) | Service provider |
| virtual [GetViewName](DefaultReportRenderer/GetViewName.md)(…) | Gets view name for the report |
| virtual [RenderAsHtml](DefaultReportRenderer/RenderAsHtml.md)(…) | Renders a report as HTML |
| virtual [RenderAsPdf](DefaultReportRenderer/RenderAsPdf.md)(…) | Renders an HTML report as pdf |
| virtual [RenderDataOnlyReport](DefaultReportRenderer/RenderDataOnlyReport.md)(…) | Renders a data only report |
| virtual [RenderExternalReport](DefaultReportRenderer/RenderExternalReport.md)(…) | Renders an external report, generally returns a RedirectResult |
| [RenderHtmlReport](DefaultReportRenderer/RenderHtmlReport.md)(…) | Renders an HTML report |
| virtual [RenderUnknownFormat](DefaultReportRenderer/RenderUnknownFormat.md)(…) | Renders an unknown format. Can be overridden in derived classes. |

## See Also

* interface [IReportRenderer](../Serenity.Net.Services/IReportRenderer.md)
* **Source:** *[DefaultReportRenderer.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Reporting/DefaultReportRenderer.cs)*