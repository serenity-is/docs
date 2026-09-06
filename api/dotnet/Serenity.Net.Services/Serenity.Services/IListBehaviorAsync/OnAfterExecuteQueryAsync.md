# IListBehaviorAsync.OnAfterExecuteQueryAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called after query is sent to database

```csharp
public Task OnAfterExecuteQueryAsync(IListRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling list request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IListRequestHandler](../IListRequestHandler.md)
* interface [IListBehaviorAsync](../IListBehaviorAsync.md)