# IProjectedQuery&lt;TResult&gt;.ListAsync method

Asynchronously executes the projection and buffers its results.

```csharp
public Task<List<TResult>> ListAsync(IDbConnection connection, 
    IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| parameters | Optional parameter values to override for this execution. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the projected list.

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)