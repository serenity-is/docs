# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.ApplyIncludeDeletedFilter method

Applies the not deleted filter to the query unless [`IncludeDeleted`](../ListRequest/IncludeDeleted.md) is true and the current user has the undelete permission for the row. Rows that do not use soft delete are always included.

```csharp
protected virtual void ApplyIncludeDeletedFilter(SqlQuery query)
```

| parameter | description |
| --- | --- |
| query |  |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)