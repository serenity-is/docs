# FindRowArgs record
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Arguments for intercepting entity find operations.

```csharp
public record FindRowArgs
```

## Public Members

| name | description |
| --- | --- |
| [FindRowArgs](FindRowArgs/FindRowArgs.md)(…) | Arguments for intercepting entity find operations. |
| [ByIdOrSingle](FindRowArgs/ByIdOrSingle.md) { get; set; } | True when a single row is expected. |
| [Id](FindRowArgs/Id.md) { get; set; } | The identifier, if the operation is by ID. |
| [Query](FindRowArgs/Query.md) { get; set; } | The fully configured query. |
| [RowType](FindRowArgs/RowType.md) { get; set; } | The type of the row. |

## See Also

* **Source:** *[IRowOperationInterceptor.cs](https://github.com/serenity-is/Serenity/blob/dc49678d1d8072c9c1817a00d72503274fc28ecf/src/services/Entity/Extensions/IRowOperationInterceptor.cs)*