# ListRequestPagingParams class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Parameters that describe how a list query should be paged, including whether the total record count is required. Used by [`ApplyPagingParams`](./ServiceQueryHelper/ApplyPagingParams.md).

```csharp
public sealed class ListRequestPagingParams
```

## Public Members

| name | description |
| --- | --- |
| [ExcludeTotalCount](ListRequestPagingParams/ExcludeTotalCount.md) { get; set; } | Gets or sets the requested [`ExcludeTotalCount`](./ListRequest/ExcludeTotalCount.md) value. `true` excludes the total count, `false` requests it, and `null` (the default, unspecified) leaves the decision to [`IncludeMore`](./ListRequestPagingParams/IncludeMore.md) and [`ExcludeTotalCountByDefault`](./ListRequestPagingParams/ExcludeTotalCountByDefault.md). |
| [ExcludeTotalCountByDefault](ListRequestPagingParams/ExcludeTotalCountByDefault.md) { get; set; } | Gets or sets whether an unspecified [`ExcludeTotalCount`](./ListRequestPagingParams/ExcludeTotalCount.md) should be treated as excluded. |
| [IncludeMore](ListRequestPagingParams/IncludeMore.md) { get; set; } | Gets or sets whether a More indicator was requested. When the total count is not explicitly requested, this asks for an extra sentinel row instead of a `COUNT(*)`. |
| [ShouldExcludeTotalCount](ListRequestPagingParams/ShouldExcludeTotalCount.md) { get; } | Gets whether the total count should be excluded, resolving [`ExcludeTotalCount`](./ListRequestPagingParams/ExcludeTotalCount.md) (an explicit value wins) against [`IncludeMore`](./ListRequestPagingParams/IncludeMore.md) and [`ExcludeTotalCountByDefault`](./ListRequestPagingParams/ExcludeTotalCountByDefault.md). |
| [Skip](ListRequestPagingParams/Skip.md) { get; set; } | Gets the number of records to skip. |
| [Take](ListRequestPagingParams/Take.md) { get; set; } | Gets or sets the number of records to take. Zero means no paging. |

## See Also

* **Source:** *[ListRequestPagingParams.cs](https://github.com/serenity-is/Serenity/blob/cab28e9506312283bcd9c44fae98b33b198f595a/src/services/Models/ListRequestPagingParams.cs)*