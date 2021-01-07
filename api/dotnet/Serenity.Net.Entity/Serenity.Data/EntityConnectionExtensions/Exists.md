# EntityConnectionExtensions.Exists&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static bool Exists<TRow>(this IDbConnection connection, ICriteria where)
    where TRow : class, IRow, new()
```

## See Also

* interface [ICriteria](../Serenity.Net.Data/../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)