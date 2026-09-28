# IProjectedQuery&lt;TResult&gt;.List method

Executes the projection and buffers its results.

```csharp
public List<TResult> List(IDbConnection connection, 
    IReadOnlyDictionary<string, object?>? parameters = null)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| parameters | Optional parameter values to override for this execution. |

## Return Value

The projected results.

## See Also

* interface [IProjectedQuery&lt;TResult&gt;](../IProjectedQuery-1.md)