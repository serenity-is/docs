# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.SelectFields method

Calls query.Select(field) for all the fields without NotMapped, and if [`AllowSelectField`](./AllowSelectField.md) and [`ShouldSelectField`](./ShouldSelectField.md) returns true.

```csharp
protected virtual void SelectFields(SqlQuery query)
```

| parameter | description |
| --- | --- |
| query | Query |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)