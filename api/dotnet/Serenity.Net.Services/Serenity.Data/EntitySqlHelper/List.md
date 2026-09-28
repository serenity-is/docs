# EntitySqlHelper.List&lt;TRow&gt; method

Lists the rows returned from executing the query.

```csharp
public static List<TRow> List<TRow>(this SqlQuery query, IDbConnection connection, 
    TRow? loaderRow = default, IReadOnlyDictionary<string, object?>? parameters = null)
    where TRow : class, IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| query | The query. |
| connection | The connection. |
| loaderRow | The loader row. |
| parameters | Values that override the query's parameters for this execution. |

## Return Value

List of rows.

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)