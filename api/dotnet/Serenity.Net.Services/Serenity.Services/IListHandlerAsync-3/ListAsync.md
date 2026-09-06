# IListHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;.ListAsync method

Processes a List request asynchronously

```csharp
public Task<TListResponse> ListAsync(IDbConnection connection, TListRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | List request |
| cancellationToken | Cancellation token |

## See Also

* interface [IListHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](../IListHandlerAsync-3.md)