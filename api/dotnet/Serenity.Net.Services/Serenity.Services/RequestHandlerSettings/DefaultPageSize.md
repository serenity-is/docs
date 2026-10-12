# RequestHandlerSettings.DefaultPageSize property

Gets or sets the default page size (take) applied when a List request does not specify one (e.g. take is zero). Zero means no default, so all records may be returned.

```csharp
public int DefaultPageSize { get; set; }
```

## Remarks

WARNING: Enabling this applies to every List request, including server side code that constructs a [`ListRequest`](../ListRequest.md) without a take and expects all records (for example exports, reports, background jobs, or nested relation loads). Such callers may silently operate on a partial list; they must call [`SuppressPagingLimits`](../RequestHandlerExtensions/SuppressPagingLimits.md) to ignore the limits. Do not enable this without auditing existing List usages. Also, grids that do not render a pager (e.g. `usePager() => false`) will be truncated with no way to reach the remaining rows, so avoid low values. A take of zero that this setting (or [`MaxPageSize`](./MaxPageSize.md)) turns into an actual page size still returns the total (a `COUNT(*)`) even when [`ExcludeTotalCountByDefault`](./ExcludeTotalCountByDefault.md) is enabled, because the caller did not ask to page. Callers that don't need the total should set [`ExcludeTotalCount`](../ListRequest/ExcludeTotalCount.md) to true, request [`IncludeMore`](../ListRequest/IncludeMore.md) (which returns a More indicator instead), or call [`SuppressPagingLimits`](../RequestHandlerExtensions/SuppressPagingLimits.md) (which also restores take to zero). Negative values are ignored (treated as zero).

## See Also

* class [RequestHandlerSettings](../RequestHandlerSettings.md)