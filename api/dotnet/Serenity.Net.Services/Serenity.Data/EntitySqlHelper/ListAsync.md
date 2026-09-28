# EntitySqlHelper.ListAsync&lt;TRow&gt; method (1 of 2)

Asynchronously lists the rows returned from executing the query.

```csharp
public static Task<List<TRow>> ListAsync<TRow>(this SqlQuery query, IDbConnection connection, 
    TRow? loaderRow, CancellationToken token)
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| query | The query. |
| connection | The connection. |
| loaderRow | The loader row. |
| token | The cancellation token. |

## Return Value

A task representing the asynchronous operation.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)

---

# EntitySqlHelper.ListAsync&lt;TRow&gt; method (2 of 2)

Asynchronously lists the rows returned from executing the query.

```csharp
public static Task<List<TRow>> ListAsync<TRow>(this SqlQuery query, IDbConnection connection, 
    TRow? loaderRow = default, IReadOnlyDictionary<string, object?>? parameters = null, 
    CancellationToken cancellationToken = default)
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| query | The query. |
| connection | The connection. |
| loaderRow | The loader row. |
| parameters | Values that override the query's parameters for this execution. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the list of rows.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)