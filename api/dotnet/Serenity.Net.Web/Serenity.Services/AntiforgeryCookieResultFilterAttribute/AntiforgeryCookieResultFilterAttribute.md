# AntiforgeryCookieResultFilterAttribute constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Append the anti forgery token as CSRF-TOKEN cookie to the response, so that AJAX calls can read it client side and send as a header.

```csharp
public AntiforgeryCookieResultFilterAttribute(IAntiforgery antiforgery)
```

| parameter | description |
| --- | --- |
| antiforgery | Antiforgery service |

## Remarks

Creates a new instance of the class

## See Also

* class [AntiforgeryCookieResultFilterAttribute](../AntiforgeryCookieResultFilterAttribute.md)