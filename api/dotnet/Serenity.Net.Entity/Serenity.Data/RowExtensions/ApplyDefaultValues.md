# RowExtensions.ApplyDefaultValues&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Applies the default values.

```csharp
public static TRow ApplyDefaultValues<TRow>(this TRow row, bool unassignedOnly = false)
    where TRow : IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| row | The row. |
| unassignedOnly | if set to `true` [unassigned only]. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | row |

## See Also

* class [TRow](../Serenity.Net.Entity/../RowExtensions.TRow.md)
* interface [IRow](../IRow.md)
* class [RowExtensions](../RowExtensions.md)