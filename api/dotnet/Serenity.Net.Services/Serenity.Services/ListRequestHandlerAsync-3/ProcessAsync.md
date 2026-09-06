# ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;.ProcessAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the list request asynchronously. This is the entry point for the handler.

```csharp
public Task<TListResponse> ProcessAsync(IDbConnection connection, TListRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | Request |
| cancellationToken | Cancellation token |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *connection* or *request* is `null`. |

## See Also

* class [TListResponse](../Serenity.Net.Services/../ListRequestHandlerAsync-3.TListResponse.md)
* class [TListRequest](../Serenity.Net.Services/../ListRequestHandlerAsync-3.TListRequest.md)
* class [ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerAsync-3.md)