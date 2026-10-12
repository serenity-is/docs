# ListRequest.ExcludeTotalCount property

Exclude the total count from the result. When `true`, the total number of records is not calculated (no extra `COUNT(*)`) and [`TotalCount`](../ListResponse-1/TotalCount.md) is left as zero. When `false`, the total is calculated for paged requests (when [`Take`](./Take.md) is greater than zero). When `null` (the default, i.e. not sent), the total is calculated for paged requests unless [`IncludeMore`](./IncludeMore.md) is true or the handler's `RequestHandlerSettings.ExcludeTotalCountByDefault` is enabled. A zero [`Take`](./Take.md) that paging limits turn into an actual page size still returns the total, regardless of that setting, unless [`IncludeMore`](./IncludeMore.md) is requested.

```csharp
public bool? ExcludeTotalCount { get; set; }
```

## See Also

* class [ListRequest](../ListRequest.md)