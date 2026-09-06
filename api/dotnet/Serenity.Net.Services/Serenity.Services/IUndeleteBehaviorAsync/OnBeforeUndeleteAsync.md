# IUndeleteBehaviorAsync.OnBeforeUndeleteAsync method

Called just before row is undeleted in database

```csharp
public Task OnBeforeUndeleteAsync(IUndeleteRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)