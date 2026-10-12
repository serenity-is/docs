# ServiceQueryHelper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains static helper methods for service handler queries.

```csharp
public static class ServiceQueryHelper
```

## Public Members

| name | description |
| --- | --- |
| static [ApplyContainsText](ServiceQueryHelper/ApplyContainsText.md)(…) | Applies contains text criteria to the query |
| static [ApplyPagingLimits](ServiceQueryHelper/ApplyPagingLimits.md)(…) | Applies the configured paging limits ([`DefaultPageSize`](./RequestHandlerSettings/DefaultPageSize.md) and [`MaxPageSize`](./RequestHandlerSettings/MaxPageSize.md)) to [`Take`](./ListRequestPagingParams/Take.md), changing it in place. A zero take is replaced by the default page size, then clamped to the maximum page size when set. |
| static [ApplyPagingParams](ServiceQueryHelper/ApplyPagingParams.md)(…) | Applies paging and count parameters, optionally requesting one additional row to detect whether more results are available. Whether the total count is calculated is resolved from [`ListRequestPagingParams`](./ListRequestPagingParams.md) (see [`ShouldExcludeTotalCount`](./ListRequestPagingParams/ShouldExcludeTotalCount.md)). |
| static [ApplySkipTakeAndCount](ServiceQueryHelper/ApplySkipTakeAndCount.md)(…) | Applies skip, take and exclude total count parameters to the query. |
| static [ApplySort](ServiceQueryHelper/ApplySort.md)(…) | Applies the sort order to the query (3 methods) |
| static [GetContainsTextFilter](ServiceQueryHelper/GetContainsTextFilter.md)(…) | Creates a contains text criteria |
| static [GetNotDeletedCriteria](ServiceQueryHelper/GetNotDeletedCriteria.md)(…) | Gets not deleted criteria for a row type, e.g. for rows that support soft delete. |
| static [UseSoftDelete](ServiceQueryHelper/UseSoftDelete.md)(…) | Returns if row uses soft delete |

## See Also

* **Source:** *[ServiceQueryHelper.cs](https://github.com/serenity-is/Serenity/blob/672c3a9116183bcea311db48e4da2bc19688f626/src/services/RequestHandlers/Helpers/ServiceQueryHelper.cs)*