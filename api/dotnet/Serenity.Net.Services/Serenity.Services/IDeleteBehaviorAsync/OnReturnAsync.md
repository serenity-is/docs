# IDeleteBehaviorAsync.OnReturnAsync method

Called before handler is returning the result

```csharp
public Task OnReturnAsync(IDeleteRequestHandler handler, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| handler | Calling delete request handler |
| cancellationToken | Cancellation token |

## See Also

* interface [IDeleteRequestHandler](../IDeleteRequestHandler.md)
* interface [IDeleteBehaviorAsync](../IDeleteBehaviorAsync.md)