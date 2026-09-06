# IUndeleteBehaviorAsync.OnAfterUndeleteAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called after row is undeleted in database

```csharp
public Task OnAfterUndeleteAsync(IUndeleteRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)