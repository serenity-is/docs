# DefaultReportRenderer constructor
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

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

* interface [IDataReportExcelRenderer](../Serenity.Net.Services/../IDataReportExcelRenderer.md)
* interface [IHtmlReportPdfRenderer](../Serenity.Net.Services/../IHtmlReportPdfRenderer.md)
* class [DefaultReportRenderer](../DefaultReportRenderer.md)