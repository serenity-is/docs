# IDeleteBehaviorAsync.OnAfterDeleteAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called after row is deleted from database

```csharp
public Task OnAfterDeleteAsync(IDeleteRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling delete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IDeleteRequestHandler](../IDeleteRequestHandler.md)
* interface [IDeleteBehaviorAsync](../IDeleteBehaviorAsync.md)