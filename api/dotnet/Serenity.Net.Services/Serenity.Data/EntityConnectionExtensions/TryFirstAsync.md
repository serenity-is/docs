# EntityConnectionExtensions.TryFirstAsync&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously tries to find first entity, allowing the caller to set criteria and fields to select through an editQuery callback.

```csharp
public static Task<TRow> TryFirstAsync<TRow>(this IDbConnection connection, 
    Action<SqlQuery> editQuery, CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| editQuery | The edit query callback. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the first entity matching the criteria, or null if not found.

## See Also

* class [TRow](../Serenity.Net.Services/../EntityConnectionExtensions.TRow.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.TryFirstAsync&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously tries to find first entity matching a where criteria.

```csharp
public static Task<TRow> TryFirstAsync<TRow>(this IDbConnection connection, ICriteria where, 
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

A task representing the asynchronous operation. The task result is the first entity matching the where criteria, or null if not found.

## See Also

* class [TRow](../Serenity.Net.Services/../EntityConnectionExtensions.TRow.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)