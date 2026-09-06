# IUndeleteBehaviorAsync.OnAfterUndeleteAsync method

Called after row is undeleted in database

```csharp
public Task OnAfterUndeleteAsync(IUndeleteRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)