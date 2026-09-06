# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.ApplyContainsText method

Applies contains text filter to the query

```csharp
protected virtual void ApplyContainsText(SqlQuery query, string containsText)
```

| parameter | description |
| --- | --- |
| query | Query |
| containsText | Contains text |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | There are no quick search fields ([`QuickSearchAttribute`](../../Serenity.Data.Mapping/QuickSearchAttribute.md) |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)