# IUndeleteBehaviorAsync.OnReturnAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called before handler is returning the result

```csharp
public Task OnReturnAsync(IUndeleteRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)