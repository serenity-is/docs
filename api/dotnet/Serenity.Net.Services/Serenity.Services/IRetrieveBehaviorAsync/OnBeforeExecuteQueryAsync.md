# IRetrieveBehaviorAsync.OnBeforeExecuteQueryAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called just before query is sent to database

```csharp
public Task OnBeforeExecuteQueryAsync(IRetrieveRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling retrieve request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IRetrieveRequestHandler](../IRetrieveRequestHandler.md)
* interface [IRetrieveBehaviorAsync](../IRetrieveBehaviorAsync.md)