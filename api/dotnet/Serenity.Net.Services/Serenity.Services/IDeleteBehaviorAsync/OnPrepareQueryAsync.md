# IDeleteBehaviorAsync.OnPrepareQueryAsync method

Called when query to load old entity is built

```csharp
public Task OnPrepareQueryAsync(IDeleteRequestHandler handler, SqlQuery query, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling delete request handler |
| query | Query |
| cancellationToken | Cancellation token |

## See Also

* interface [IDeleteRequestHandler](../IDeleteRequestHandler.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [IDeleteBehaviorAsync](../IDeleteBehaviorAsync.md)