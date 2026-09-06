# HtmlReportCallbackUrlInterceptor.InterceptCallback method

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

* class [ReportRenderResult](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderResult.md)
* class [ReportRenderOptions](../../../Serenity.Net.Services/Serenity.Reporting/ReportRenderOptions.md)
* class [HtmlReportCallbackUrlInterceptor](../HtmlReportCallbackUrlInterceptor.md)