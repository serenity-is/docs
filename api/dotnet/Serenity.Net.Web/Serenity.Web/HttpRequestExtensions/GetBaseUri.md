# HttpRequestExtensions.GetBaseUri method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets the base uri for the current request

```csharp
public static Uri GetBaseUri(this HttpRequest request, bool pathBase = true)
```

| parameter | description |
| --- | --- |
| request | HTTP request |
| pathBase | Include path base |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Request is null |

## See Also

* class [HttpRequestExtensions](../HttpRequestExtensions.md)