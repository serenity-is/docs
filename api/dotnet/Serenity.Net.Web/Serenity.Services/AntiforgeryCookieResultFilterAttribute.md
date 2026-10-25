# AntiforgeryCookieResultFilterAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Appends the anti forgery token as a `CSRF-TOKEN` cookie to the response, so that AJAX calls can read it client side and send it as a header.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class AntiforgeryCookieResultFilterAttribute : ResultFilterAttribute
```

| parameter | description |
| --- | --- |
| antiforgery | The antiforgery service. |

## Public Members

| name | description |
| --- | --- |
| [AntiforgeryCookieResultFilterAttribute](AntiforgeryCookieResultFilterAttribute/AntiforgeryCookieResultFilterAttribute.md)(…) | Appends the anti forgery token as a `CSRF-TOKEN` cookie to the response, so that AJAX calls can read it client side and send it as a header. |
| override [OnResultExecuting](AntiforgeryCookieResultFilterAttribute/OnResultExecuting.md)(…) |  |

## Remarks

Initializes a new instance of the [`AntiforgeryCookieResultFilterAttribute`](./AntiforgeryCookieResultFilterAttribute.md) class.

## See Also

* **Source:** *[AntiforgeryCookieResultFilter.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Antiforgery/AntiforgeryCookieResultFilter.cs)*