# QueryWithParamsExtensions.Freeze&lt;TQuery&gt; method

Freezes the query and its parameters, and prepares its SQL text for reuse.

```csharp
public static TQuery Freeze<TQuery>(this TQuery self)
    where TQuery : IQueryWithParams
```

| parameter | description |
| --- | --- |
| TQuery | The query type. |
| self | The query. |

## Return Value

The query itself.

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [QueryWithParamsExtensions](../QueryWithParamsExtensions.md)