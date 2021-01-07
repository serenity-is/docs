# EntitySqlHelper.List&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static List<TRow> List<TRow>(this SqlQuery query, IDbConnection connection, 
    TRow loaderRow = default(TRow))
    where TRow : class, IRow
```

## See Also

* class [TRow](../Serenity.Net.Entity/../EntitySqlHelper.TRow.md)
* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntitySqlHelper](../EntitySqlHelper.md)