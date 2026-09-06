# DefaultReportRenderer class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of IReportRenderer.

```csharp
public class DefaultReportRenderer : IReportRenderer
```

| parameter | description |
| --- | --- |
| excelRenderer | The Excel renderer. |
| htmlReportPdfRenderer | The HTML report PDF renderer. |
| serviceProvider | The service provider. |
| httpContextAccessor | The HTTP context accessor. |

## Public Members

| name | description |
| --- | --- |
| [DefaultReportRenderer](DefaultReportRenderer/DefaultReportRenderer.md)(…) | Default implementation of IReportRenderer. |
| [Render](DefaultReportRenderer/Render.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| readonly [excelRenderer](DefaultReportRenderer/excelRenderer.md) | The Excel renderer. |
| readonly [htmlReportPdfRenderer](DefaultReportRenderer/htmlReportPdfRenderer.md) | The HTML report PDF renderer. |
| readonly [httpContextAccessor](DefaultReportRenderer/httpContextAccessor.md) | The HTTP context accessor. |
| readonly [serviceProvider](DefaultReportRenderer/serviceProvider.md) | The service provider. |
| virtual [GetViewName](DefaultReportRenderer/GetViewName.md)(…) | Gets the view name for the report. |
| virtual [RenderAsHtml](DefaultReportRenderer/RenderAsHtml.md)(…) | Renders a report as HTML. |
| virtual [RenderAsPdf](DefaultReportRenderer/RenderAsPdf.md)(…) | Renders an HTML report as PDF. |
| virtual [RenderDataOnlyReport](DefaultReportRenderer/RenderDataOnlyReport.md)(…) | Renders a data only report. |
| virtual [RenderExternalReport](DefaultReportRenderer/RenderExternalReport.md)(…) | Renders an external report, generally returns a ReportRenderResult with a redirect URI. |
| [RenderHtmlReport](DefaultReportRenderer/RenderHtmlReport.md)(…) | Renders an HTML report. |
| virtual [RenderUnknownFormat](DefaultReportRenderer/RenderUnknownFormat.md)(…) | Renders an unknown format. Can be overridden in derived classes. |

## Remarks

Initializes a new instance of the [`DefaultReportRenderer`](./DefaultReportRenderer.md) class.

## See Also

* interface [IReportRenderer](../../Serenity.Net.Services/Serenity.Reporting/IReportRenderer.md)
* **Source:** *[DefaultReportRenderer.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Reporting/DefaultReportRenderer.cs)*