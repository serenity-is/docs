# DefaultReportRenderer.RenderUnknownFormat method

Renders an unknown format. Can be overridden in derived classes.

```csharp
protected virtual ReportRenderResult RenderUnknownFormat(IReport report, 
    ReportRenderOptions options)
```

| parameter | description |
| --- | --- |
| report | The report. |
| options | The options. |

## Return Value

The render result.

## Exceptions

| exception | condition |
| --- | --- |
| NotImplementedException | Thrown by default. |

## See Also

* class [ReportRenderResult](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderResult.md)
* interface [IReport](../../../Serenity.Net.Services/Serenity.Reporting/IReport.md)
* class [ReportRenderOptions](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderOptions.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)