# ServiceQueryHelper.ApplyPagingParams method

Applies paging and count parameters, optionally requesting one additional row to detect whether more results are available. Whether the total count is calculated is resolved from [`ListRequestPagingParams`](../ListRequestPagingParams.md) (see [`ShouldExcludeTotalCount`](../ListRequestPagingParams/ShouldExcludeTotalCount.md)).

```csharp
public static SqlQuery ApplyPagingParams(this SqlQuery query, ListRequestPagingParams paging, 
    out ListRequestPagingState pagingState)
```

| parameter | description |
| --- | --- |
| query | Query |
| paging | Paging parameters. |
| pagingState | Receives the selected paging strategy. |

## Return Value

The query.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *query* or *paging* is null. |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestPagingParams](../ListRequestPagingParams.md)
* class [ListRequestPagingState](../ListRequestPagingState.md)
* class [ServiceQueryHelper](../ServiceQueryHelper.md)