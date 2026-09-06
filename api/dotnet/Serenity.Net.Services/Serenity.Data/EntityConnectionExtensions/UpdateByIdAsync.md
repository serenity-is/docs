# EntityConnectionExtensions.UpdateByIdAsync&lt;TRow&gt; method

Asynchronously updates the entity by its identifier. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers.

```csharp
public static Task<int> UpdateByIdAsync<TRow>(this IDbConnection connection, TRow row, 
    ExpectedRows expectedRows = ExpectedRows.One, CancellationToken cancellationToken = default)
    where TRow : IIdRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| row | The row. |
| expectedRows | The expected number of rows to be updated, by default 1. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the number of updated rows.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | ID field of the row has a null value! |
| InvalidOperationException | Expected rows and number of updated rows do not match! |

## See Also

* enum [ExpectedRows](../ExpectedRows.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)