# IProjectedQuery&lt;TResult&gt;.Query method

Executes the projection and returns its results. Results are buffered by default.

```csharp
public IEnumerable<TResult> Query(IDbConnection connection, 
    IReadOnlyDictionary<string, object?>? parameters = null, bool buffered = true)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| parameters | Optional parameter values to override for this execution. |
| buffered | Whether to buffer all results before returning. |

## Return Value

The projected results.

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)