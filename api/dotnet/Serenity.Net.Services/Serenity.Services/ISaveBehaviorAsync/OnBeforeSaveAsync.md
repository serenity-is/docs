# ISaveBehaviorAsync.OnBeforeSaveAsync method

Called just before row is inserted to / updated in database

```csharp
public Task OnBeforeSaveAsync(ISaveRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* interface [ISaveBehaviorAsync](../ISaveBehaviorAsync.md)