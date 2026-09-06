# IListBehaviorAsync.OnPrepareQueryAsync method

Called when query is built

```csharp
public Task OnPrepareQueryAsync(IListRequestHandler handler, SqlQuery query, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling list request handler |
| query | Query |
| cancellationToken | Cancellation token |

## See Also

* interface [IListRequestHandler](../IListRequestHandler.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [IListBehaviorAsync](../IListBehaviorAsync.md)