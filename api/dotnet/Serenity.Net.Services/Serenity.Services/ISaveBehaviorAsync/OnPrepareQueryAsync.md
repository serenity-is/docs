# ISaveBehaviorAsync.OnPrepareQueryAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when query to load old entity is built

```csharp
public Task OnPrepareQueryAsync(ISaveRequestHandler handler, SqlQuery query, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| query | Query |
| cancellationToken | Cancellation token |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [ISaveBehaviorAsync](../ISaveBehaviorAsync.md)