# RetrieveRequestHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.ProcessAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the retrieve request asynchronously. This is the entry point for the handler.

```csharp
public Task<TRetrieveResponse> ProcessAsync(IDbConnection connection, TRetrieveRequest request, 
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

* class [TRetrieveResponse](../Serenity.Net.Services/../RetrieveRequestHandlerAsync-3.TRetrieveResponse.md)
* class [TRetrieveRequest](../Serenity.Net.Services/../RetrieveRequestHandlerAsync-3.TRetrieveRequest.md)
* class [RetrieveRequestHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandlerAsync-3.md)