# DefaultReportRenderer.GetViewName method

Gets the view name for the report.

```csharp
protected virtual string GetViewName(IReport report, ReportRenderOptions options)
```

| parameter | description |
| --- | --- |
| report | The report. |
| options | The options. |

## Return Value

The view name.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | The report has no design attribute. |

## See Also

* interface [IReport](../../../Serenity.Net.Services/Serenity.Reporting/IReport.md)
* class [ReportRenderOptions](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderOptions.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)