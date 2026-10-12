# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.GetPagingParams method

Validates the request paging values and builds the effective [`ListRequestPagingParams`](../ListRequestPagingParams.md) for the current request. Negative skip / take values are rejected as a validation error, while larger values are clamped to [`MaxPageSize`](../RequestHandlerSettings/MaxPageSize.md) so that the response can report the applied take. Paging limits are skipped when the request suppresses them (see [`SuppressPagingLimits`](../RequestHandlerExtensions/SuppressPagingLimits.md)). The returned params also carry [`ExcludeTotalCount`](../ListRequest/ExcludeTotalCount.md), [`IncludeMore`](../ListRequest/IncludeMore.md) and [`ExcludeTotalCountByDefault`](../RequestHandlerSettings/ExcludeTotalCountByDefault.md), forcing [`ExcludeTotalCount`](../ListRequest/ExcludeTotalCount.md) when the query has distinct fields.

```csharp
protected virtual ListRequestPagingParams GetPagingParams()
```

## Return Value

The effective paging parameters.

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | Skip or take is negative. |

## See Also

* class [ListRequestPagingParams](../ListRequestPagingParams.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)