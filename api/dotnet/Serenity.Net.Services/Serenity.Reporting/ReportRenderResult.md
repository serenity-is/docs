# ReportRenderResult class
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Render result for a report

```csharp
public class ReportRenderResult
```

## Public Members

| name | description |
| --- | --- |
| [ReportRenderResult](ReportRenderResult/ReportRenderResult.md)() | The default constructor. |
| [ContentBytes](ReportRenderResult/ContentBytes.md) { get; set; } | File content bytes |
| [FileExtension](ReportRenderResult/FileExtension.md) { get; set; } | File extension |
| [MimeType](ReportRenderResult/MimeType.md) { get; set; } | Mime type if available |
| [Model](ReportRenderResult/Model.md) { get; set; } | View model, only returned in preview mode for HTML |
| [RedirectUri](ReportRenderResult/RedirectUri.md) { get; set; } | A redirect URI, only returned for external reports |
| [ViewData](ReportRenderResult/ViewData.md) { get; } | A list of view data to pass to the view data dictionary, only returned in preview mode for HTML |
| [ViewName](ReportRenderResult/ViewName.md) { get; set; } | A view name, only returned in preview mode for HTML |

## See Also

* **Source:** *[ReportRenderResult.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Reporting/Rendering/ReportRenderResult.cs)*