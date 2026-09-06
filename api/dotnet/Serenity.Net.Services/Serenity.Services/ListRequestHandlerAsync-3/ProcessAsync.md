# ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;.ProcessAsync method

Processes the list request asynchronously. This is the entry point for the handler.

```csharp
public Task<TListResponse> ProcessAsync(IDbConnection connection, TListRequest request, 
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

* class [ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerAsync-3.md)