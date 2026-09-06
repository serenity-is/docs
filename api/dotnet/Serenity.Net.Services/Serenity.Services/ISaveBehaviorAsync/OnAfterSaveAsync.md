# ISaveBehaviorAsync.OnAfterSaveAsync method

Called after row is inserted to / updated in database

```csharp
public Task OnAfterSaveAsync(ISaveRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* interface [ISaveBehaviorAsync](../ISaveBehaviorAsync.md)