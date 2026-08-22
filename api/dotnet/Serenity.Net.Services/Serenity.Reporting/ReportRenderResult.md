# ReportRenderResult class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Render result for a report.

```csharp
public class ReportRenderResult
```

## Public Members

| name | description |
| --- | --- |
| [ReportRenderResult](ReportRenderResult/ReportRenderResult.md)() | The default constructor. |
| [ContentBytes](ReportRenderResult/ContentBytes.md) { get; set; } | Gets or sets the file content bytes. |
| [FileExtension](ReportRenderResult/FileExtension.md) { get; set; } | Gets or sets the file extension. |
| [FileName](ReportRenderResult/FileName.md) { get; set; } | Gets or sets the suggested file name (without extension). |
| [MimeType](ReportRenderResult/MimeType.md) { get; set; } | Gets or sets the MIME type, if available. |
| [Model](ReportRenderResult/Model.md) { get; set; } | Gets or sets the view model, only returned in preview mode for HTML. |
| [RedirectUri](ReportRenderResult/RedirectUri.md) { get; set; } | Gets or sets a redirect URI, only returned for external reports. |
| [ViewData](ReportRenderResult/ViewData.md) { get; } | Gets a list of view data to pass to the view data dictionary, only returned in preview mode for HTML. |
| [ViewName](ReportRenderResult/ViewName.md) { get; set; } | Gets or sets a view name, only returned in preview mode for HTML. |

## See Also

* **Source:** *[ReportRenderResult.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Reporting/Rendering/ReportRenderResult.cs)*