# EntityConnectionExtensions.UpdateById&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static void UpdateById<TRow>(this IDbConnection connection, TRow row, 
    ExpectedRows expectedRows = ExpectedRows.One)
    where TRow : IIdRow
```

## See Also

* class [TRow](../Serenity.Net.Entity/../EntityConnectionExtensions.TRow.md)
* enum [ExpectedRows](../Serenity.Net.Data/../ExpectedRows.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)