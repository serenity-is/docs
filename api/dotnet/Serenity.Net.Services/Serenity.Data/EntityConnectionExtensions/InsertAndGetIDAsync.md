# EntityConnectionExtensions.InsertAndGetIDAsync&lt;TRow&gt; method

Asynchronously inserts the specified entity and returns the ID of record inserted. Only works for identity columns of integer type. Note that this operates at a low level, it does not perform any validation or permission check and does not call service behaviors / handlers.

```csharp
public static Task<long?> InsertAndGetIDAsync<TRow>(this IDbConnection connection, TRow row, 
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

A task representing the asynchronous operation. The task result is the ID of the record inserted.

## See Also

* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)