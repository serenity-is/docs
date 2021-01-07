# EntityConnectionExtensions.ExistsById&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static bool ExistsById<TRow>(this IDbConnection connection, object id)
    where TRow : class, IRow, IIdRow, new()
```

## See Also

* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)