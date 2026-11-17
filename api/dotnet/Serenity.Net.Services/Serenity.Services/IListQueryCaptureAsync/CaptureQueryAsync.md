# IListQueryCaptureAsync.CaptureQueryAsync method

Builds the query the handler would execute for the request, without executing it. See [`CaptureQueryAsync`](../ListRequestHandlerAsync-3/CaptureQueryAsync.md).

```csharp
public Task<SqlQuery> CaptureQueryAsync(IDbConnection connection, ListRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| request | List request |
| cancellationToken | Cancellation token |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequest](../ListRequest.md)
* interface [IListQueryCaptureAsync](../IListQueryCaptureAsync.md)