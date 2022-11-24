# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.ApplySort method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies the Request.Sort order to the query. Sorts by [`GetNativeSort`](GetNativeSort.md) if no sort columns are passed, or the list is empty.

```csharp
protected virtual void ApplySort(SqlQuery query)
```

| parameter | description |
| --- | --- |
| query | Query |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)