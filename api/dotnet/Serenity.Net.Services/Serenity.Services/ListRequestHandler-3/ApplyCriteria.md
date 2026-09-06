# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.ApplyCriteria method

Applies the Request.Criteria to the query if it is not null or empty, and replaced field references with their corresponding expressions by calling [`ReplaceFieldExpressions`](./ReplaceFieldExpressions.md)

```csharp
protected virtual void ApplyCriteria(SqlQuery query)
```

| parameter | description |
| --- | --- |
| query |  |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)