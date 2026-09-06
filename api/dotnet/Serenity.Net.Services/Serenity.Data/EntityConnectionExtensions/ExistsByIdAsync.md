# EntityConnectionExtensions.ExistsByIdAsync&lt;TRow&gt; method

Asynchronously checks if the record with specified ID exists.

```csharp
public static Task<bool> ExistsByIdAsync<TRow>(this IDbConnection connection, object id, 
    CancellationToken cancellationToken = default)
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| id | The identifier. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is true if the record exists.

## See Also

* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)