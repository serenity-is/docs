# RetrieveRequestHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.ProcessAsync method

Processes the retrieve request asynchronously. This is the entry point for the handler.

```csharp
public Task<TRetrieveResponse> ProcessAsync(IDbConnection connection, TRetrieveRequest request, 
    CancellationToken cancellationToken = default)
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

* class [RetrieveRequestHandlerAsync&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandlerAsync-3.md)