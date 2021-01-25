# EntityConnectionExtensions.DeleteById&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Deletes the entity by its identifier. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers.

```csharp
public static int DeleteById<TRow>(this IDbConnection connection, object id, 
    ExpectedRows expectedRows = ExpectedRows.One)
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| id | The identifier. |
| expectedRows | The expected number of rows to be deleted, 1 by default. |

## Return Value

Number of deleted rows

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Expected rows and number of deleted rows does not match! |

## See Also

* enum [ExpectedRows](../Serenity.Net.Data/../ExpectedRows.md)
* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)