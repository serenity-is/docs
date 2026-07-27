# EntityConnectionExtensions.UpdateById&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Updates the entity by its identifier. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers.

```csharp
public static int UpdateById<TRow>(this IDbConnection connection, TRow row, 
    ExpectedRows expectedRows = ExpectedRows.One)
    where TRow : IIdRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| row | The row. |
| expectedRows | The expected number of rows to be updated, by default 1. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | ID field of row has null value! |
| InvalidOperationException | Expected rows and number of updated rows does not match! |

## See Also

* class [TRow](../Serenity.Net.Services/../EntityConnectionExtensions.TRow.md)
* enum [ExpectedRows](../ExpectedRows.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)