# EntityConnectionExtensions.CountAsync&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously gets count of all records.

```csharp
public static Task<int> CountAsync<TRow>(this IDbConnection connection, 
    CancellationToken cancellationToken = default(CancellationToken))
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| cancellationToken | The cancellation token. |

## Return Value

A task representing the asynchronous operation. The task result is the number of records in the table.

## See Also

* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)

---

# EntityConnectionExtensions.CountAsync&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Asynchronously gets count of records matching a specified criteria.

```csharp
public static Task<int> CountAsync<TRow>(this IDbConnection connection, ICriteria where, 
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

A task representing the asynchronous operation. The task result is the number of records matching the specified criteria.

## See Also

* interface [ICriteria](../../Serenity/ICriteria.md)
* interface [IRow](../IRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)