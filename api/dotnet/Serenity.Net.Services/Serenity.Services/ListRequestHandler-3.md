# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class ListRequestHandler<TRow, TListRequest, TListResponse> : IListRequestProcessor, 
    IRequestHandler<TRow>, IRequestType<TListRequest>, IResponseType<TListResponse>
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
    where TListResponse : ListResponse<TRow>, new()
```

## Public Members

| name | description |
| --- | --- |
| [ListRequestHandler](ListRequestHandler-3/ListRequestHandler.md)(…) |  |
| [Cache](ListRequestHandler-3/Cache.md) { get; } |  |
| [Connection](ListRequestHandler-3/Connection.md) { get; } |  |
| [Context](ListRequestHandler-3/Context.md) { get; } |  |
| [DistinctFields](ListRequestHandler-3/DistinctFields.md) { get; } |  |
| [Localizer](ListRequestHandler-3/Localizer.md) { get; } |  |
| [Permissions](ListRequestHandler-3/Permissions.md) { get; } |  |
| [Query](ListRequestHandler-3/Query.md) { get; } |  |
| [StateBag](ListRequestHandler-3/StateBag.md) { get; } |  |
| [User](ListRequestHandler-3/User.md) { get; } |  |
| [GetDistinctFields](ListRequestHandler-3/GetDistinctFields.md)() |  |
| [IgnoreEqualityFilter](ListRequestHandler-3/IgnoreEqualityFilter.md)(…) |  |
| [Process](ListRequestHandler-3/Process.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](ListRequestHandler-3/behaviors-.md) |  |
| [ignoredEqualityFilters-](ListRequestHandler-3/ignoredEqualityFilters-.md) |  |
| [Request](ListRequestHandler-3/Request.md) |  |
| [Response](ListRequestHandler-3/Response.md) |  |
| [Row](ListRequestHandler-3/Row.md) |  |
| virtual [AddFieldContainsCriteria](ListRequestHandler-3/AddFieldContainsCriteria.md)(…) |  |
| virtual [AllowSelectField](ListRequestHandler-3/AllowSelectField.md)(…) |  |
| virtual [ApplyContainsText](ListRequestHandler-3/ApplyContainsText.md)(…) |  |
| virtual [ApplyCriteria](ListRequestHandler-3/ApplyCriteria.md)(…) |  |
| virtual [ApplyEqualityFilter](ListRequestHandler-3/ApplyEqualityFilter.md)(…) |  |
| virtual [ApplyFieldContainsText](ListRequestHandler-3/ApplyFieldContainsText.md)(…) |  |
| virtual [ApplyFieldEqualityFilter](ListRequestHandler-3/ApplyFieldEqualityFilter.md)(…) |  |
| virtual [ApplyFilters](ListRequestHandler-3/ApplyFilters.md)(…) |  |
| virtual [ApplyIncludeDeletedFilter](ListRequestHandler-3/ApplyIncludeDeletedFilter.md)(…) |  |
| virtual [ApplyKeyOrder](ListRequestHandler-3/ApplyKeyOrder.md)(…) |  |
| virtual [ApplySort](ListRequestHandler-3/ApplySort.md)(…) |  |
| virtual [ApplySortBy](ListRequestHandler-3/ApplySortBy.md)(…) |  |
| virtual [CreateQuery](ListRequestHandler-3/CreateQuery.md)() |  |
| virtual [GetBehaviors](ListRequestHandler-3/GetBehaviors.md)() |  |
| virtual [GetNativeSort](ListRequestHandler-3/GetNativeSort.md)() |  |
| virtual [GetQuickSearchFields](ListRequestHandler-3/GetQuickSearchFields.md)(…) |  |
| [IsEmptyEqualityFilterValue](ListRequestHandler-3/IsEmptyEqualityFilterValue.md)(…) |  |
| [IsIncluded](ListRequestHandler-3/IsIncluded.md)(…) |  (2 methods) |
| virtual [OnAfterExecuteQuery](ListRequestHandler-3/OnAfterExecuteQuery.md)() |  |
| virtual [OnBeforeExecuteQuery](ListRequestHandler-3/OnBeforeExecuteQuery.md)() |  |
| virtual [OnReturn](ListRequestHandler-3/OnReturn.md)() |  |
| virtual [PrepareQuery](ListRequestHandler-3/PrepareQuery.md)(…) |  |
| virtual [ProcessEntity](ListRequestHandler-3/ProcessEntity.md)(…) |  |
| virtual [ReplaceFieldExpressions](ListRequestHandler-3/ReplaceFieldExpressions.md)(…) |  |
| virtual [SelectField](ListRequestHandler-3/SelectField.md)(…) |  |
| virtual [SelectFields](ListRequestHandler-3/SelectFields.md)(…) |  |
| virtual [ShouldSelectField](ListRequestHandler-3/ShouldSelectField.md)(…) |  |
| virtual [ValidatePermissions](ListRequestHandler-3/ValidatePermissions.md)() |  |
| virtual [ValidateRequest](ListRequestHandler-3/ValidateRequest.md)() |  |

## See Also

* interface [IListRequestProcessor](IListRequestProcessor.md)
* interface [IRequestHandler&lt;TRow&gt;](IRequestHandler-1.md)
* class [TRow](../Serenity.Net.Services/ListRequestHandler-3.TRow.md)
* interface [IRequestType&lt;TRequestType&gt;](IRequestType-1.md)
* class [TListRequest](../Serenity.Net.Services/ListRequestHandler-3.TListRequest.md)
* interface [IResponseType&lt;TResponseType&gt;](IResponseType-1.md)
* class [TListResponse](../Serenity.Net.Services/ListRequestHandler-3.TListResponse.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [ListRequest](ListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* **Source:** *[ListRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/ListRequestHandler.cs)*