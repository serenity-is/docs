# AntiforgeryCookieResultFilterAttribute constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Appends the anti forgery token as a `CSRF-TOKEN` cookie to the response, so that AJAX calls can read it client side and send it as a header.

```csharp
public AntiforgeryCookieResultFilterAttribute(IAntiforgery antiforgery)
```

| parameter | description |
| --- | --- |
| antiforgery | The antiforgery service. |

## Remarks

Initializes a new instance of the [`AntiforgeryCookieResultFilterAttribute`](../AntiforgeryCookieResultFilterAttribute.md) class.

## See Also

* class [AntiforgeryCookieResultFilterAttribute](../AntiforgeryCookieResultFilterAttribute.md)