# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.ApplyFieldEqualityFilter method

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
| ArgumentOutOfRangeException | The field is not allowed to be filtered. |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [Field](../../Serenity.Data/Field.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)