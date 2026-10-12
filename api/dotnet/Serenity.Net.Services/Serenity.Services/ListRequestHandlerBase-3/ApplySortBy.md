# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.ApplySortBy method

Applies a sort order to the query Fields with read permissions the user does not have are ignored.

```csharp
protected virtual void ApplySortBy(SqlQuery query, SortBy sortBy)
```

| parameter | description |
| --- | --- |
| query | Query |
| sortBy | Sort order |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [SortBy](../SortBy.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)