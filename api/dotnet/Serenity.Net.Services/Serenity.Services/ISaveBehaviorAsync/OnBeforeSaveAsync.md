# ISaveBehaviorAsync.OnBeforeSaveAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called just before row is inserted to / updated in database

```csharp
public Task OnBeforeSaveAsync(ISaveRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* interface [ISaveBehaviorAsync](../ISaveBehaviorAsync.md)