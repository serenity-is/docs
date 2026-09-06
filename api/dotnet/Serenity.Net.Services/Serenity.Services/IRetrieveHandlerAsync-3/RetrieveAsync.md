# IRetrieveHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.RetrieveAsync method

Processes a Retrieve request asynchronously.

```csharp
public Task<TRetrieveResponse> RetrieveAsync(IDbConnection connection, TRetrieveRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | Retrieve request |
| cancellationToken | Cancellation token |

## Return Value

The retrieve response.

## See Also

* interface [IRetrieveHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../IRetrieveHandlerAsync-3.md)