# DefaultReportRenderer constructor

Default implementation of IReportRenderer.

```csharp
public DefaultReportRenderer(IDataReportExcelRenderer excelRenderer, 
    IHtmlReportPdfRenderer htmlReportPdfRenderer, IServiceProvider serviceProvider, 
    IHttpContextAccessor httpContextAccessor = null)
```

| parameter | description |
| --- | --- |
| excelRenderer | The Excel renderer. |
| htmlReportPdfRenderer | The HTML report PDF renderer. |
| serviceProvider | The service provider. |
| httpContextAccessor | The HTTP context accessor. |

## Remarks

Initializes a new instance of the [`DefaultReportRenderer`](../DefaultReportRenderer.md) class.

## See Also

* interface [IDataReportExcelRenderer](../../../Serenity.Net.Services/Serenity.Reporting/IDataReportExcelRenderer.md)
* interface [IHtmlReportPdfRenderer](../../../Serenity.Net.Services/Serenity.Reporting/IHtmlReportPdfRenderer.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)