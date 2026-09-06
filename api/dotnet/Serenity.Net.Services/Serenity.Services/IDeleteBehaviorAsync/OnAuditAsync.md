# IDeleteBehaviorAsync.OnAuditAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called after row is deleted and auditing should be performed

```csharp
public Task OnAuditAsync(IDeleteRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling delete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IDeleteRequestHandler](../IDeleteRequestHandler.md)
* interface [IDeleteBehaviorAsync](../IDeleteBehaviorAsync.md)