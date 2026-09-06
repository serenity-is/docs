# IRetrieveBehaviorAsync.OnValidateRequestAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when retrieve request is validated

```csharp
public Task OnValidateRequestAsync(IRetrieveRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling retrieve request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IRetrieveRequestHandler](../IRetrieveRequestHandler.md)
* interface [IRetrieveBehaviorAsync](../IRetrieveBehaviorAsync.md)