# ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;.ApplyFiltersAsync method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies all the filters including Request.EqualityFilter, Request.Criteria and Request.IncludeDeleted to the query.

```csharp
protected virtual Task ApplyFiltersAsync(SqlQuery query, 
    CancellationToken cancellationToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| query | Query |
| cancellationToken | Cancellation token |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandlerAsync&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerAsync-3.md)