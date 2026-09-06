# IRetrieveRequestProcessorAsync.ProcessAsync method

Processes the [`RetrieveRequest`](../RetrieveRequest.md) asynchronously and returns a [`IRetrieveResponse`](../IRetrieveResponse.md)

```csharp
public Task<IRetrieveResponse> ProcessAsync(IDbConnection connection, RetrieveRequest request, 
    CancellationToken cancellationToken = default)
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