# EntitySqlQueryExtensions.WithSelf&lt;TQuery&gt; method

Returns the query and assigns the same instance to a reference for use within a fluent chain.

```csharp
public static TQuery WithSelf<TQuery>(this TQuery query, out TQuery reference)
    where TQuery : QueryWithParams
```

| parameter | description |
| --- | --- |
| TQuery | The concrete query type. |
| query | The query. |
| reference | Receives the same query instance. |

## Return Value

The query itself.

## See Also

* class [QueryWithParams](../QueryWithParams.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)