# IUndeleteBehaviorAsync.OnValidateRequestAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when undelete request is validated

```csharp
public Task OnValidateRequestAsync(IUndeleteRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)