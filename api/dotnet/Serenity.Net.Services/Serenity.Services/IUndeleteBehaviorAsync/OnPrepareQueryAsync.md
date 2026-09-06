# IUndeleteBehaviorAsync.OnPrepareQueryAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when query to load old entity is built

```csharp
public Task OnPrepareQueryAsync(IUndeleteRequestHandler handler, SqlQuery query, 
    CancellationToken cancellationToken = default(CancellationToken))
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