# IUndeleteBehaviorAsync.OnValidateRequestAsync method

Called when undelete request is validated

```csharp
public Task OnValidateRequestAsync(IUndeleteRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)