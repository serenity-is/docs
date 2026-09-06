# ISaveBehaviorAsync.OnValidateRequestAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when save request is validated

```csharp
public Task OnValidateRequestAsync(ISaveRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* interface [ISaveBehaviorAsync](../ISaveBehaviorAsync.md)