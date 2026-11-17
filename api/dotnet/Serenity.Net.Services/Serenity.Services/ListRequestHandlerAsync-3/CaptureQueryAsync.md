# ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;.CaptureQueryAsync method

Builds the query this handler would execute for the request, without executing it. The request is validated, and the query is prepared and filtered by the handler and its behaviors as usual, with [`ExecutionMode`](../ListRequestHandlerBase-3/ExecutionMode.md) set to QueryCapture. The query has no key order, sort, paging or total count, as it is meant to be used as a source of another query. Anything the handler or its behaviors would do after the query is executed, e.g. in ProcessEntity, OnAfterExecuteQuery or OnReturn, does not happen.

```csharp
public Task<SqlQuery> CaptureQueryAsync(IDbConnection connection, TListRequest request, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | Connection, which the handler and its behaviors may use to run their own queries while building the query |
| request | Request |
| cancellationToken | Cancellation token |

## Return Value

The query

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerAsync-3.md)