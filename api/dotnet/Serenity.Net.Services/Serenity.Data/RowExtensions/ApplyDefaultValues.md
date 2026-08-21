# RowExtensions.ApplyDefaultValues&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies the default values.

```csharp
public static TRow ApplyDefaultValues<TRow>(this TRow row, bool unassignedOnly = false)
    where TRow : IRow
```

| parameter | description |
| --- | --- |
| TRow | The type of the row. |
| row | The row. |
| unassignedOnly | if set to `true`, only unassigned fields are set. |

## Return Value

The row with default values applied.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | row is null. |

## See Also

* class [TRow](../Serenity.Net.Services/../RowExtensions.TRow.md)
* interface [IRow](../IRow.md)
* class [RowExtensions](../RowExtensions.md)