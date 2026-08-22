# HtmlReportCallbackUrlInterceptor.InterceptCallback method
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Intercepts a report callback, applying impersonation and transient grants from the report auth cookie.

```csharp
public ReportRenderResult InterceptCallback(ReportRenderOptions options, 
    Func<ReportRenderOptions, ReportRenderResult> action)
```

| parameter | description |
| --- | --- |
| options | The render options. |
| action | The callback action. |

## Return Value

The report render result.

## See Also

* class [ReportRenderResult](../Serenity.Net.Services/../ReportRenderResult.md)
* class [ReportRenderOptions](../Serenity.Net.Services/../ReportRenderOptions.md)
* class [HtmlReportCallbackUrlInterceptor](../HtmlReportCallbackUrlInterceptor.md)