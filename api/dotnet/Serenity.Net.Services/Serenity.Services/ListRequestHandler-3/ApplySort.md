# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.ApplySort method

Applies the Request.Sort order to the query. Sorts by [`GetNativeSort`](./GetNativeSort.md) if no sort columns are passed, or the list is empty.

```csharp
protected virtual void ApplySort(SqlQuery query)
```

| parameter | description |
| --- | --- |
| query | Query |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)