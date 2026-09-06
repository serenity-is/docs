# IListBehaviorAsync.OnAfterExecuteQueryAsync method

Called after query is sent to database

```csharp
public Task OnAfterExecuteQueryAsync(IListRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling list request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IListRequestHandler](../IListRequestHandler.md)
* interface [IListBehaviorAsync](../IListBehaviorAsync.md)