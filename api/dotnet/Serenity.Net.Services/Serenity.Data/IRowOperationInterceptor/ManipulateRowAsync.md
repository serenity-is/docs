# IRowOperationInterceptor.ManipulateRowAsync method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Intercepts the async EntityConnectionExtensions DeleteById/Insert/Update methods. The default implementation forwards to [`ManipulateRow`](ManipulateRow.md).

```csharp
public Task<OptionalValue<long?>> ManipulateRowAsync(Type rowType, OptionalValue<object> id, 
    IRow row, ExpectedRows expectedRows, bool getNewId, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| rowType | Type of the row. |
| id | The identifier if Update/Delete is used. |
| row | The row being manipulated. Is null for delete. |
| expectedRows | The expected number of rows to be manipulated. Default is 1. |
| getNewId | True if InsertAndGetID is called. |
| cancellationToken | Cancellation token |

## Return Value

The generated identity value, or null if none was generated.

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* interface [IRow](../IRow.md)
* enum [ExpectedRows](../ExpectedRows.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)