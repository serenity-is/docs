# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.ApplyEqualityFilter method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies the Request.Equality filter to the query

```csharp
protected virtual void ApplyEqualityFilter(SqlQuery query)
```

| parameter | description |
| --- | --- |
| query | Query |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | A field name in the Request.EqualityFilter could not be matched with a field in current row |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)