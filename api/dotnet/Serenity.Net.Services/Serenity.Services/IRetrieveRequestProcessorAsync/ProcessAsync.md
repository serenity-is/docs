# IRetrieveRequestProcessorAsync.ProcessAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the [`RetrieveRequest`](../RetrieveRequest.md) asynchronously and returns a [`IRetrieveResponse`](../IRetrieveResponse.md)

```csharp
public Task<IRetrieveResponse> ProcessAsync(IDbConnection connection, RetrieveRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | Retrieve request |
| cancellationToken | Cancellation token |

## See Also

* interface [IRetrieveResponse](../IRetrieveResponse.md)
* class [RetrieveRequest](../RetrieveRequest.md)
* interface [IRetrieveRequestProcessorAsync](../IRetrieveRequestProcessorAsync.md)