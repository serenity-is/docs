# IUndeleteBehaviorAsync.OnReturnAsync method

Called before handler is returning the result

```csharp
public Task OnReturnAsync(IUndeleteRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)