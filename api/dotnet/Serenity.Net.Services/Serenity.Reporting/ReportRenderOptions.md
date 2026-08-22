# ReportRenderOptions class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Options used to render a report.

```csharp
public class ReportRenderOptions
```

## Public Members

| name | description |
| --- | --- |
| [ReportRenderOptions](ReportRenderOptions/ReportRenderOptions.md)() | The default constructor. |
| [ExportFormat](ReportRenderOptions/ExportFormat.md) { get; set; } | The requested export format if specified, like "xlsx", "html", "pdf" etc. This is only useful for cases where a report can be rendered to multiple types. |
| [PreviewMode](ReportRenderOptions/PreviewMode.md) { get; set; } | Gets or sets a value indicating whether the report is rendered in preview mode, which is only useful for HTML output. |
| [ReportKey](ReportRenderOptions/ReportKey.md) { get; set; } | The report key, if it is not specified in report type as an attribute. Will be ignored if report will be rendered directly, e.g. not via a callback. |
| [ReportParams](ReportRenderOptions/ReportParams.md) { get; set; } | The set of report params usually a serialized JSON object to be passed to the URL callback. These params should already be applied to the passed report instance. Will be ignored if the report is rendered directly, e.g. without a callback. |

## See Also

* **Source:** *[ReportRenderOptions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Reporting/Rendering/ReportRenderOptions.cs)*