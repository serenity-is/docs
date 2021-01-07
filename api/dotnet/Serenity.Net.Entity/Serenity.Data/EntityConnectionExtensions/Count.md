# EntityConnectionExtensions.Count&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static int Count<TRow>(this IDbConnection connection)
    where TRow : class, IRow, new()
```

## See Also

* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.Count&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static int Count<TRow>(this IDbConnection connection, ICriteria where)
    where TRow : class, IRow, new()
```

## See Also

* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)