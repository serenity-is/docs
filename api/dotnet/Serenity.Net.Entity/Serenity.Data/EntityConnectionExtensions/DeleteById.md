# EntityConnectionExtensions.DeleteById&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static int DeleteById<TRow>(this IDbConnection connection, object id, 
    ExpectedRows expectedRows = ExpectedRows.One)
    where TRow : class, IRow, IIdRow, new()
```

## See Also

* enum [ExpectedRows](../Serenity.Net.Data/../ExpectedRows.md)
* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)