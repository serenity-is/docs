# QueryWithParamsExtensions.FreezeParams&lt;TQuery&gt; method

Freezes the query's parameters so they can no longer be added or changed.

```csharp
public static TQuery FreezeParams<TQuery>(this TQuery self)
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