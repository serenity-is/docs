# IUndeleteBehaviorAsync.OnAuditAsync method

Called after row is undeleted and auditing should be performed

```csharp
public Task OnAuditAsync(IUndeleteRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)