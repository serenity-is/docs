# ISaveBehaviorAsync.OnAuditAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called after row is inserted to / updated and auditing should be performed

```csharp
public Task OnAuditAsync(ISaveRequestHandler handler, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* interface [ISaveBehaviorAsync](../ISaveBehaviorAsync.md)