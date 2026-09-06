# IListBehaviorAsync.OnValidateRequestAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when list request is validated

```csharp
public Task OnValidateRequestAsync(IListRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling list request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IListRequestHandler](../IListRequestHandler.md)
* interface [IListBehaviorAsync](../IListBehaviorAsync.md)