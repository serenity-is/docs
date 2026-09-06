# EntityConnectionExtensions.SingleAsync&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously finds a single entity, allowing caller to edit the criteria and set of fields to load through a editQuery callback.

```csharp
public static Task<TRow> SingleAsync<TRow>(this IDbConnection connection, 
    Action<SqlQuery> editQuery, CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| editQuery | The callback to edit query. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the single entity matching the criteria set by editQuery.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | No records matching the specified criteria. |
| InvalidOperationException | Multiple records matching the specified criteria. |

## See Also

* class [TRow](../Serenity.Net.Services/../EntityConnectionExtensions.TRow.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.SingleAsync&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously finds a single entity matching the specified criteria. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields.

```csharp
public static Task<TRow> SingleAsync<TRow>(this IDbConnection connection, ICriteria where, 
    CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| where | The where criteria. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the single entity matching the specified criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | No matching records found. |
| InvalidOperationException | Multiple records matching the specified criteria. |

## See Also

* class [TRow](../Serenity.Net.Services/../EntityConnectionExtensions.TRow.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)