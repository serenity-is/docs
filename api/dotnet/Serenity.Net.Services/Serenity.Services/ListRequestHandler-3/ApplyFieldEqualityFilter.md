# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.ApplyFieldEqualityFilter method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies a field equality filter, e.g. one that is passed via Request.EqualityFilter to the query. It validates field flags like DenyFiltering and NotMapped and Never to check if the field is allowed to be filtered.

```csharp
protected virtual void ApplyFieldEqualityFilter(SqlQuery query, Field field, object value)
```

| parameter | description |
| --- | --- |
| query | Query |
| field | Field |
| value | Equality value. Can be a enumerable for multi value filtering. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException |  |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)