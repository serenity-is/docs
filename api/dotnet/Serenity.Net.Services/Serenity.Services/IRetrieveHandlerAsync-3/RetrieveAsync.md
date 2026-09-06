# IRetrieveHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.RetrieveAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes a Retrieve request asynchronously.

```csharp
public Task<TRetrieveResponse> RetrieveAsync(IDbConnection connection, TRetrieveRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | Retrieve request |
| cancellationToken | Cancellation token |

## Return Value

The retrieve response.

## See Also

* class [TRetrieveResponse](../Serenity.Net.Services/../IRetrieveHandlerAsync-3.TRetrieveResponse.md)
* class [TRetrieveRequest](../Serenity.Net.Services/../IRetrieveHandlerAsync-3.TRetrieveRequest.md)
* interface [IRetrieveHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../IRetrieveHandlerAsync-3.md)