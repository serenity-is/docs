# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.Process method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the list request. This is the entry point for the handler.

```csharp
public TListResponse Process(IDbConnection connection, TListRequest request)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | Request |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection or the request is null |

## See Also

* class [TListResponse](../Serenity.Net.Services/../ListRequestHandler-3.TListResponse.md)
* class [TListRequest](../Serenity.Net.Services/../ListRequestHandler-3.TListRequest.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)