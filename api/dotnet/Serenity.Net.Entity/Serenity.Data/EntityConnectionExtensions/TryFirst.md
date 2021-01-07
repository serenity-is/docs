# EntityConnectionExtensions.TryFirst&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static TRow TryFirst<TRow>(this IDbConnection connection, Action<SqlQuery> editQuery)
    where TRow : class, IRow, new()
```

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* class [SqlQuery](../Serenity.Net.Data/../SqlQuery.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.TryFirst&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static TRow TryFirst<TRow>(this IDbConnection connection, ICriteria where)
    where TRow : class, IRow, new()
```

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)