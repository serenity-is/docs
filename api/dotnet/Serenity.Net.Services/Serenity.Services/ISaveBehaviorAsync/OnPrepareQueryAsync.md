# ISaveBehaviorAsync.OnPrepareQueryAsync method

Called when query to load old entity is built

```csharp
public Task OnPrepareQueryAsync(ISaveRequestHandler handler, SqlQuery query, 
    CancellationToken cancellationToken = default)
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