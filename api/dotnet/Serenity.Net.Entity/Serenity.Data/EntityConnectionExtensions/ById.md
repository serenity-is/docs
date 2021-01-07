# EntityConnectionExtensions.ById&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static TRow ById<TRow>(this IDbConnection connection, object id)
    where TRow : class, IRow, IIdRow, new()
```

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.ById&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static TRow ById<TRow>(this IDbConnection connection, object id, Action<SqlQuery> editQuery)
    where TRow : class, IRow, IIdRow, new()
```

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)