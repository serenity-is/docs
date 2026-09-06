# EntityConnectionExtensions.FirstAsync&lt;TRow&gt; method (1 of 2)

Asynchronously finds first entity, allowing the caller to set criteria and fields to select through an editQuery callback.

```csharp
public static Task<TRow> FirstAsync<TRow>(this IDbConnection connection, 
    Action<SqlQuery> editQuery, CancellationToken cancellationToken = default)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| editQuery | The edit query callback. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the first entity matching the criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | No records matching the specified criteria. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.FirstAsync&lt;TRow&gt; method (2 of 2)

Asynchronously finds first entity matching a where criteria.

```csharp
public static Task<TRow> FirstAsync<TRow>(this IDbConnection connection, ICriteria where, 
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

A task representing the asynchronous operation. The task result is the first entity matching the where criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | No records matching the specified criteria. |

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)