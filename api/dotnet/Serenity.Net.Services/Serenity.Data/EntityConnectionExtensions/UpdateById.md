# EntityConnectionExtensions.UpdateById&lt;TRow&gt; method

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
| InvalidOperationException | ID field of the row has a null value! |
| InvalidOperationException | Expected rows and number of updated rows do not match! |

## See Also

* enum [ExpectedRows](../ExpectedRows.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)