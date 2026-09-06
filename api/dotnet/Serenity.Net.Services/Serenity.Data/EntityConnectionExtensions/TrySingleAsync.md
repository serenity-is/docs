# EntityConnectionExtensions.TrySingleAsync&lt;TRow&gt; method (1 of 2)

Asynchronously tries to find a single entity, allowing caller to edit the criteria and set of fields to load through a editQuery callback.

```csharp
public static Task<TRow> TrySingleAsync<TRow>(this IDbConnection connection, 
    Action<SqlQuery> editQuery, CancellationToken cancellationToken = default)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| editQuery | The edit query. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the single entity matching the criteria set by editQuery, or null if not found.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Multiple records matching the specified criteria. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.TrySingleAsync&lt;TRow&gt; method (2 of 2)

Asynchronously tries to find a single entity matching the specified criteria. This method selects only the table fields, and no foreign / calculated fields. Use other overloads if you want to select different set of fields.

```csharp
public static Task<TRow> TrySingleAsync<TRow>(this IDbConnection connection, ICriteria where, 
    CancellationToken cancellationToken = default)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| where | The where criteria. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the single entity matching the specified criteria, or null if no matching record is found.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Multiple records matching the criteria found. |

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)