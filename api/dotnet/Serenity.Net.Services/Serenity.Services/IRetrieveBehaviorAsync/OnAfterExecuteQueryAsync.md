# IRetrieveBehaviorAsync.OnAfterExecuteQueryAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called after query is sent to database

```csharp
public Task OnAfterExecuteQueryAsync(IRetrieveRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling retrieve request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IRetrieveRequestHandler](../IRetrieveRequestHandler.md)
* interface [IRetrieveBehaviorAsync](../IRetrieveBehaviorAsync.md)