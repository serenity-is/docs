# EntityConnectionExtensions.DeleteByIdAsync&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously deletes the entity by its identifier. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers.

```csharp
public static Task<int> DeleteByIdAsync<TRow>(this IDbConnection connection, object id, 
    ExpectedRows expectedRows = ExpectedRows.One, 
    CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| id | The identifier. |
| expectedRows | The expected number of rows to be deleted, 1 by default. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the number of deleted rows.

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Expected rows and number of deleted rows do not match! |

## See Also

* enum [ExpectedRows](../ExpectedRows.md)
* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)