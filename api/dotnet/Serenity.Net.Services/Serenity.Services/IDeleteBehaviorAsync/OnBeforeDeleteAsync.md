# IDeleteBehaviorAsync.OnBeforeDeleteAsync method

Called just before row is deleted from database

```csharp
public Task OnBeforeDeleteAsync(IDeleteRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling delete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IDeleteRequestHandler](../IDeleteRequestHandler.md)
* interface [IDeleteBehaviorAsync](../IDeleteBehaviorAsync.md)