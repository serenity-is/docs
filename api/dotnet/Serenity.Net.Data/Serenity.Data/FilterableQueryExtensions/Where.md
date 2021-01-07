# FilterableQueryExtensions.Where&lt;T&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a filter to query

```csharp
public static T Where<T>(this T self, ICriteria filter)
    where T : IFilterableQuery
```

| parameter | description |
| --- | --- |
| T | Query class |
| self | Query |
| filter | Filter |

## Return Value

Query itself.

## See Also

* class [T](../Serenity.Net.Data/../FilterableQueryExtensions.T.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IFilterableQuery](../IFilterableQuery.md)
* class [FilterableQueryExtensions](../FilterableQueryExtensions.md)