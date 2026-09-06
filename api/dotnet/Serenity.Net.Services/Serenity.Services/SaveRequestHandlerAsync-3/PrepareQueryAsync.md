# SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;.PrepareQueryAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Prepares the query for selecting old record in an update operation.

```csharp
protected virtual Task<SqlQuery> PrepareQueryAsync(
    CancellationToken cancellationToken = default(CancellationToken))
```

## Return Value

The prepared query.

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerAsync-3.md)