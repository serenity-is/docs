# IDeleteBehaviorAsync.OnAuditAsync method

Called after row is deleted and auditing should be performed

```csharp
public Task OnAuditAsync(IDeleteRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling delete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IDeleteRequestHandler](../IDeleteRequestHandler.md)
* interface [IDeleteBehaviorAsync](../IDeleteBehaviorAsync.md)