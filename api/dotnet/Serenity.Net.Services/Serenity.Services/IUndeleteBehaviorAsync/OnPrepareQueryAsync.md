# IUndeleteBehaviorAsync.OnPrepareQueryAsync method

Called when query to load old entity is built

```csharp
public Task OnPrepareQueryAsync(IUndeleteRequestHandler handler, SqlQuery query, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| query | Query |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)