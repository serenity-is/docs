# IProjectedQuery&lt;TResult&gt;.QueryAsync method

Asynchronously streams the projected results.

```csharp
public IAsyncEnumerable<TResult> QueryAsync(IDbConnection connection, 
    IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| parameters | Optional parameter values to override for this execution. |
| cancellationToken | The cancellation token. |

## Return Value

An asynchronous stream of projected results.

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)