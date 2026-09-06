# IRetrieveBehaviorAsync.OnPrepareQueryAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when query is built

```csharp
public Task OnPrepareQueryAsync(IRetrieveRequestHandler handler, SqlQuery query, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling retrieve request handler |
| query | Query |
| cancellationToken | Cancellation token |

## See Also

* interface [IRetrieveRequestHandler](../IRetrieveRequestHandler.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [IRetrieveBehaviorAsync](../IRetrieveBehaviorAsync.md)