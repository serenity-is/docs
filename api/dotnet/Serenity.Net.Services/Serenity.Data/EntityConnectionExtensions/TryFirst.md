# EntityConnectionExtensions.TryFirst&lt;TRow&gt; method (1 of 2)

Tries to finds first entity, allowing the caller to set criteria and fields to select through an editQuery callback.

```csharp
public static TRow TryFirst<TRow>(this IDbConnection connection, Action<SqlQuery> editQuery)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| editQuery | The edit query callback. |

## Return Value

First entity matching the criteria, or null if not found.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.TryFirst&lt;TRow&gt; method (2 of 2)

Tries to find first entity matching a where criteria.

```csharp
public static TRow TryFirst<TRow>(this IDbConnection connection, ICriteria where)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| where | The where criteria. |

## Return Value

First entity matching the where criteria, or null if not found.

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)