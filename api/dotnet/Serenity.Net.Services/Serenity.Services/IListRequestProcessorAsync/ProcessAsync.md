# IListRequestProcessorAsync.ProcessAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Processes the [`ListRequest`](../ListRequest.md) asynchronously and returns a [`IListResponse`](../IListResponse.md)

```csharp
public Task<IListResponse> ProcessAsync(IDbConnection connection, ListRequest request, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | List request |
| cancellationToken | Cancellation token |

## See Also

* interface [IListResponse](../IListResponse.md)
* class [ListRequest](../ListRequest.md)
* interface [IListRequestProcessorAsync](../IListRequestProcessorAsync.md)