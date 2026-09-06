# FilterableQueryExtensions.Where&lt;T&gt; method

Adds a filter to query.

```csharp
public static T Where<T>(this T self, ICriteria filter)
    where T : IFilterableQuery
```

| parameter | description |
| --- | --- |
| T | Query class. |
| self | Query. |
| filter | Filter. |

## Return Value

Query itself.

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IFilterableQuery](../IFilterableQuery.md)
* class [FilterableQueryExtensions](../FilterableQueryExtensions.md)