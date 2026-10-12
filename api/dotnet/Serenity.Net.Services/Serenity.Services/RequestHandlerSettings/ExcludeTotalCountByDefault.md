# RequestHandlerSettings.ExcludeTotalCountByDefault property

Gets or sets whether the total record count is excluded by default for list requests that do not explicitly specify [`ExcludeTotalCount`](../ListRequest/ExcludeTotalCount.md) (i.e. it is `null` / not sent). Default is false, which preserves the historical behavior of calculating the total (and issuing a `COUNT(*)`) for paged requests. When a request has a zero take that [`DefaultPageSize`](./DefaultPageSize.md) / [`MaxPageSize`](./MaxPageSize.md) turns into an actual page size, the total is still returned as if [`ExcludeTotalCount`](../ListRequest/ExcludeTotalCount.md) was false, unless [`IncludeMore`](../ListRequest/IncludeMore.md) was requested (a More indicator is returned instead).

```csharp
public bool ExcludeTotalCountByDefault { get; set; }
```

## Remarks

WARNING: Enabling this changes the default behavior of every List request that does not explicitly send [`ExcludeTotalCount`](../ListRequest/ExcludeTotalCount.md), including grid requests that rely on [`TotalCount`](../ListResponse-1/TotalCount.md) for their pager. Such grids will report a zero total until they explicitly send `ExcludeTotalCount = false`. Audit existing usages before enabling. Requests that explicitly send `ExcludeTotalCount = false` are unaffected, which is why the request property is nullable. Also note that requests with [`IncludeMore`](../ListRequest/IncludeMore.md) already skip the count.

## See Also

* class [RequestHandlerSettings](../RequestHandlerSettings.md)