# ISaveBehaviorAsync.OnAuditAsync method

Called after row is inserted to / updated and auditing should be performed

```csharp
public Task OnAuditAsync(ISaveRequestHandler handler, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* interface [ISaveBehaviorAsync](../ISaveBehaviorAsync.md)