# IDeleteBehaviorAsync.OnReturnAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called before handler is returning the result

```csharp
public Task OnReturnAsync(IDeleteRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling delete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IDeleteRequestHandler](../IDeleteRequestHandler.md)
* interface [IDeleteBehaviorAsync](../IDeleteBehaviorAsync.md)