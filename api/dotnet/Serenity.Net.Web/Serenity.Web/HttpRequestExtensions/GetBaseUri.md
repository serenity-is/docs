# HttpRequestExtensions.GetBaseUri method

Gets the base URI for the current request.

```csharp
public static Uri GetBaseUri(this HttpRequest request, bool pathBase = true)
```

| parameter | description |
| --- | --- |
| request | The HTTP request. |
| pathBase | Whether to include the path base. |

## Return Value

The base URI.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *request* is `null`. |

## See Also

* class [HttpRequestExtensions](../HttpRequestExtensions.md)