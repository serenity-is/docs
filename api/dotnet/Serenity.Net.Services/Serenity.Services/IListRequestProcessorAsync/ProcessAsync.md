# IListRequestProcessorAsync.ProcessAsync method

Processes the [`ListRequest`](../ListRequest.md) asynchronously and returns a [`IListResponse`](../IListResponse.md)

```csharp
public Task<IListResponse> ProcessAsync(IDbConnection connection, ListRequest request, 
    CancellationToken cancellationToken = default)
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