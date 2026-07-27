# IReportCallbackInterceptor interface
**namespace:** *[Serenity.Reporting](../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for a report callback interceptor that is called by ~/Serenity.Extensions/Report/Render. This is implemented by HtmlReportCallbackUrlInterceptor to implement impersonation and transient granting during report callbacks.

```csharp
public interface IReportCallbackInterceptor
```

## Members

| name | description |
| --- | --- |
| [InterceptCallback](IReportCallbackInterceptor/InterceptCallback.md)(…) | Intercepts ReportController Render action callbacks. |

## See Also

* **Source:** *[IReportCallbackInterceptor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Reporting/IReportCallbackInterceptor.cs)*