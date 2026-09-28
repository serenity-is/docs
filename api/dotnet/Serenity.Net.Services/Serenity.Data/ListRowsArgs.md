# ListRowsArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Arguments for intercepting entity list and count operations.

```csharp
public record ListRowsArgs
```

## Public Members

| name | description |
| --- | --- |
| [ListRowsArgs](ListRowsArgs/ListRowsArgs.md)(…) | Arguments for intercepting entity list and count operations. |
| [CountOnly](ListRowsArgs/CountOnly.md) { get; set; } | True when the query is for a count operation. |
| [Query](ListRowsArgs/Query.md) { get; set; } | The fully configured query. |
| [RowType](ListRowsArgs/RowType.md) { get; set; } | The type of the row. |

## See Also

* **Source:** *[IRowOperationInterceptor.cs](https://github.com/serenity-is/Serenity/blob/dc49678d1d8072c9c1817a00d72503274fc28ecf/src/services/Entity/Extensions/IRowOperationInterceptor.cs)*