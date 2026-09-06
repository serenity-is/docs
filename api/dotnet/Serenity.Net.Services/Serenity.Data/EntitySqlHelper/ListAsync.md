# EntitySqlHelper.ListAsync&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously lists the rows returned from executing the query.

```csharp
public static Task<List<TRow>> ListAsync<TRow>(this SqlQuery query, IDbConnection connection, 
    TRow loaderRow = default(TRow), 
    CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| query | The query. |
| connection | The connection. |
| loaderRow | The loader row. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the list of rows.

## See Also

* class [TRow](../Serenity.Net.Services/../EntitySqlHelper.TRow.md)
* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)