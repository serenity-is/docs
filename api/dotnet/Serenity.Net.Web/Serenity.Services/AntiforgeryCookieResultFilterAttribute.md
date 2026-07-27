# AntiforgeryCookieResultFilterAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Append the anti forgery token as CSRF-TOKEN cookie to the response, so that AJAX calls can read it client side and send as a header.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class AntiforgeryCookieResultFilterAttribute : ResultFilterAttribute
```

| parameter | description |
| --- | --- |
| antiforgery | Antiforgery service |

## Public Members

| name | description |
| --- | --- |
| [AntiforgeryCookieResultFilterAttribute](AntiforgeryCookieResultFilterAttribute/AntiforgeryCookieResultFilterAttribute.md)(…) | Append the anti forgery token as CSRF-TOKEN cookie to the response, so that AJAX calls can read it client side and send as a header. |
| override [OnResultExecuting](AntiforgeryCookieResultFilterAttribute/OnResultExecuting.md)(…) |  |

## Remarks

Creates a new instance of the class

## See Also

* **Source:** *[AntiforgeryCookieResultFilter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/AntiforgeryCookieResultFilter.cs)*