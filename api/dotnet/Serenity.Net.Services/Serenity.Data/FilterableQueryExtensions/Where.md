# FilterableQueryExtensions.Where&lt;T&gt; method

Adds a filter string to query.

```csharp
public static T Where<T>(this T self, string filter)
    where T : IFilterableQuery
```

| parameter | description |
| --- | --- |
| T | Query class. |
| self | Query. |
| filter | Filter string. |

## Return Value

Query itself.

## See Also

* interface [IFilterableQuery](../IFilterableQuery.md)
* class [FilterableQueryExtensions](../FilterableQueryExtensions.md)