# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.ApplyEqualityFilter method

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

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)