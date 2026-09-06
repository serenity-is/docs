# EntityConnectionExtensions.ExistsAsync&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously checks if record matching specified criteria exists.

```csharp
public static Task<bool> ExistsAsync<TRow>(this IDbConnection connection, ICriteria where, 
    CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| where | The where criteria. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is true if a record matching the criteria exists.

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)