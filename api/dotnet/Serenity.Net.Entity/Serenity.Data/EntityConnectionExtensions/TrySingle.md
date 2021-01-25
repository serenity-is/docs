# EntityConnectionExtensions.TrySingle&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Tries to find a single entity, allowing caller to edit the criteria and set of fields to load through a editQuery callback.

```csharp
public static TRow TrySingle<TRow>(this IDbConnection connection, Action<SqlQuery> editQuery)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| editQuery | The edit query. |

## Return Value

Single entity matching the criteria set by editQuery, or null if not found.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Multiple records matching the specified criteria. |

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.TrySingle&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Tries to find a single entity matching the specified criteria. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields.

```csharp
public static TRow TrySingle<TRow>(this IDbConnection connection, ICriteria where)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| where | The where criteria. |

## Return Value

The single entity matching the specified criteria, or null if no matching record found

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Multiple records matching the criteria found |

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)