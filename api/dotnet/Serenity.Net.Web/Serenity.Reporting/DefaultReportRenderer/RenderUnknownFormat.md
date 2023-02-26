# DefaultReportRenderer.RenderUnknownFormat method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Renders an unknown format. Can be overridden in derived classes.

```csharp
protected virtual ReportRenderResult RenderUnknownFormat(IReport report, 
    ReportRenderOptions options)
```

| parameter | description |
| --- | --- |
| report | Report |
| options | Options |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | Throws argument null by default |

## See Also

* class [ReportRenderResult](../Serenity.Net.Services/../ReportRenderResult.md)
* interface [IReport](../Serenity.Net.Services/../IReport.md)
* class [ReportRenderOptions](../Serenity.Net.Services/../ReportRenderOptions.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)