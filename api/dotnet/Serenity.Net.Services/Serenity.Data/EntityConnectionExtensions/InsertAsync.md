# EntityConnectionExtensions.InsertAsync&lt;TRow&gt; method

Asynchronously inserts the specified entity. Note that this operates at a low level, it does not perform any validation or permission check, and does not call service behaviors / handlers.

```csharp
public static Task InsertAsync<TRow>(this IDbConnection connection, TRow row, 
    CancellationToken cancellationToken = default)
    where TRow : IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| row | The row. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation.

## See Also

* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)