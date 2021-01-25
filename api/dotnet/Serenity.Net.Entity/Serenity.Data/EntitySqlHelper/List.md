# EntitySqlHelper.List&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Lists the rows returned from executing the query.

```csharp
public static List<TRow> List<TRow>(this SqlQuery query, IDbConnection connection, 
    TRow loaderRow = default(TRow))
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| query | The query. |
| connection | The connection. |
| loaderRow | The loader row. |

## Return Value

List of rows

## See Also

* class [TRow](../Serenity.Net.Entity/../EntitySqlHelper.TRow.md)
* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)