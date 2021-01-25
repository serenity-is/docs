# EntityConnectionExtensions.ExistsById&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Checks if the record with specified ID exists.

```csharp
public static bool ExistsById<TRow>(this IDbConnection connection, object id)
    where TRow : class, IRow, IIdRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| connection | The connection. |
| id | The identifier. |

## Return Value

True if record exists

## See Also

* interface [IRow](../IRow.md)
* interface [IIdRow](../IIdRow.md)
* class [EntityConnectionExtensions](../EntityConnectionExtensions.md)