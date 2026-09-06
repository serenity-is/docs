# IRetrieveBehaviorAsync.OnAfterExecuteQueryAsync method

Called after query is sent to database

```csharp
public Task OnAfterExecuteQueryAsync(IRetrieveRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling retrieve request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IRetrieveRequestHandler](../IRetrieveRequestHandler.md)
* interface [IRetrieveBehaviorAsync](../IRetrieveBehaviorAsync.md)