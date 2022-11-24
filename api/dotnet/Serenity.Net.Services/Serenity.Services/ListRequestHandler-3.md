# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for list request handlers

```csharp
public class ListRequestHandler<TRow, TListRequest, TListResponse> : 
    IListHandler<TRow, TListRequest, TListResponse>, IListRequestProcessor
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
    where TListResponse : ListResponse<TRow>, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TListRequest | List request type |
| TListResponse | List response type |

## Public Members

| name | description |
| --- | --- |
| [ListRequestHandler](ListRequestHandler-3/ListRequestHandler.md)(…) | Creates an instance of the class |
| [Cache](ListRequestHandler-3/Cache.md) { get; } | Gets the two level cache from the request context |
| [Connection](ListRequestHandler-3/Connection.md) { get; } | Gets current connection |
| [Context](ListRequestHandler-3/Context.md) { get; } | Gets the request context |
| [DistinctFields](ListRequestHandler-3/DistinctFields.md) { get; } | Gets list of distinct fields |
| [Localizer](ListRequestHandler-3/Localizer.md) { get; } | Gets localizer from the request context |
| [Permissions](ListRequestHandler-3/Permissions.md) { get; } | Gets permission service from the request context |
| [Query](ListRequestHandler-3/Query.md) { get; } | Gets the select query |
| [StateBag](ListRequestHandler-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [User](ListRequestHandler-3/User.md) { get; } | Gets current user from the request context |
| [GetDistinctFields](ListRequestHandler-3/GetDistinctFields.md)() | Gets an array of distinct fields by checking Request.DistinctFields. It might be different than the passed list, if the list contains an invalid field or a field that is not allowed to be selected, like NotMapped and Never etc. |
| [IgnoreEqualityFilter](ListRequestHandler-3/IgnoreEqualityFilter.md)(…) | Adds the field to the list of ignored equality filters, so that having this field in the Request.EqualityFilter won't raise an exception |
| [List](ListRequestHandler-3/List.md)(…) |  |
| [Process](ListRequestHandler-3/Process.md)(…) | Processes the list request. This is the entry point for the handler. |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](ListRequestHandler-3/behaviors-.md) | Lazy list of behaviors that is activated for this request |
| [ignoredEqualityFilters-](ListRequestHandler-3/ignoredEqualityFilters-.md) | Set of ignored equality filter entries |
| [lookupAccessMode-](ListRequestHandler-3/lookupAccessMode-.md) | True if the list handler is in lookup access mode, e.g. it only allows access to lookup fields |
| [Request](ListRequestHandler-3/Request.md) | Response object |
| [Response](ListRequestHandler-3/Response.md) | Request object |
| [Row](ListRequestHandler-3/Row.md) | The entity used for querying / metadata lookup |
| virtual [AddFieldContainsCriteria](ListRequestHandler-3/AddFieldContainsCriteria.md)(…) | Applies a contains criteria based on containsText, id (if the contains text can be parsed to an integer ID), searchType and numericOnly parameters. |
| virtual [AllowSelectField](ListRequestHandler-3/AllowSelectField.md)(…) | Returns true if the field should be allowed to be selected, based on is read permission, selectlevel.never flag, and lookup access mode |
| virtual [ApplyContainsText](ListRequestHandler-3/ApplyContainsText.md)(…) | Applies contains text filter to the query |
| virtual [ApplyCriteria](ListRequestHandler-3/ApplyCriteria.md)(…) | Applies the Request.Criteria to the query if it is not null or empty, and replaced field references with their corresponding expressions by calling [`ReplaceFieldExpressions`](ListRequestHandler-3/ReplaceFieldExpressions.md) |
| virtual [ApplyEqualityFilter](ListRequestHandler-3/ApplyEqualityFilter.md)(…) | Applies the Request.Equality filter to the query |
| virtual [ApplyFieldContainsText](ListRequestHandler-3/ApplyFieldContainsText.md)(…) | Applies a field contains criteria to the query by calling [`AddFieldContainsCriteria`](ListRequestHandler-3/AddFieldContainsCriteria.md) |
| virtual [ApplyFieldEqualityFilter](ListRequestHandler-3/ApplyFieldEqualityFilter.md)(…) | Applies a field equality filter, e.g. one that is passed via Request.EqualityFilter to the query. It validates field flags like DenyFiltering and NotMapped and Never to check if the field is allowed to be filtered. |
| virtual [ApplyFilters](ListRequestHandler-3/ApplyFilters.md)(…) | Applies all the filters including Request.EqualityFilter, Request.Criteria and Request.IncludeDeleted to the query. |
| virtual [ApplyIncludeDeletedFilter](ListRequestHandler-3/ApplyIncludeDeletedFilter.md)(…) | Applies include deleted filter to the query if Request.IncludeDeleted is true |
| virtual [ApplyKeyOrder](ListRequestHandler-3/ApplyKeyOrder.md)(…) | Applies the key order which is ID field (IIdRow) |
| virtual [ApplySort](ListRequestHandler-3/ApplySort.md)(…) | Applies the Request.Sort order to the query. Sorts by [`GetNativeSort`](ListRequestHandler-3/GetNativeSort.md) if no sort columns are passed, or the list is empty. |
| virtual [ApplySortBy](ListRequestHandler-3/ApplySortBy.md)(…) | Applies a sort order to the query |
| virtual [CreateQuery](ListRequestHandler-3/CreateQuery.md)() | Creates a query instance with the dialect for current connection. |
| virtual [GetBehaviors](ListRequestHandler-3/GetBehaviors.md)() | Gets the list of list behaviors |
| virtual [GetNativeSort](ListRequestHandler-3/GetNativeSort.md)() | Gets the native sort order, which includes name field by default, unless the row has [SortOrder] attributes. |
| virtual [GetQuickSearchFields](ListRequestHandler-3/GetQuickSearchFields.md)(…) | Gets the list of quick search fields (QuickSearchAttribute) based on the containsField argument. |
| [IsEmptyEqualityFilterValue](ListRequestHandler-3/IsEmptyEqualityFilterValue.md)(…) | Checks if the equality filter value is empty. It returns true for null, empty string, or empty IEnumerable. |
| [IsIncluded](ListRequestHandler-3/IsIncluded.md)(…) | Returns true if field is included in [`IncludeColumns`](ListRequest/IncludeColumns.md) (2 methods) |
| virtual [OnAfterExecuteQuery](ListRequestHandler-3/OnAfterExecuteQuery.md)() | Called after executing the list query |
| virtual [OnBeforeExecuteQuery](ListRequestHandler-3/OnBeforeExecuteQuery.md)() | Called before executing the list query |
| virtual [OnReturn](ListRequestHandler-3/OnReturn.md)() | Called just before returning the response |
| virtual [PrepareQuery](ListRequestHandler-3/PrepareQuery.md)(…) | Prepares query by calling [`SelectFields`](ListRequestHandler-3/SelectFields.md). |
| virtual [ProcessEntity](ListRequestHandler-3/ProcessEntity.md)(…) | Can be overridden in a derived class to make some changes in a returned entity just before it gets added to the Response.Entities list |
| virtual [ReplaceFieldExpressions](ListRequestHandler-3/ReplaceFieldExpressions.md)(…) | Replaces field references, e.g. property names and field name with their corresponding expression by using the [`CriteriaFieldExpressionReplacer`](../Serenity.Data/CriteriaFieldExpressionReplacer.md) |
| virtual [SelectField](ListRequestHandler-3/SelectField.md)(…) | Calls query.Select(field) |
| virtual [SelectFields](ListRequestHandler-3/SelectFields.md)(…) | Calls query.Select(field) for all the fields without NotMapped, and if [`AllowSelectField`](ListRequestHandler-3/AllowSelectField.md) and [`ShouldSelectField`](ListRequestHandler-3/ShouldSelectField.md) returns true. |
| virtual [ShouldSelectField](ListRequestHandler-3/ShouldSelectField.md)(…) | Returns true if the field should be selected, based on current ColumnSelection, field MinSelectLevelAttribute, the field being a not mapped (NotMappedAttribute) field, table field, or a view / expression field. |
| virtual [ValidatePermissions](ListRequestHandler-3/ValidatePermissions.md)() | Validates if the user is allowed to query this entity type by checking ReadPermissionAttribute and ServiceLookupPermissionAttribute if the request is in lookup access mode. |
| virtual [ValidateRequest](ListRequestHandler-3/ValidateRequest.md)() | Validates the request by calling [`ValidatePermissions`](ListRequestHandler-3/ValidatePermissions.md) |

## See Also

* interface [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](IListHandler-3.md)
* class [TRow](../Serenity.Net.Services/ListRequestHandler-3.TRow.md)
* class [TListRequest](../Serenity.Net.Services/ListRequestHandler-3.TListRequest.md)
* class [TListResponse](../Serenity.Net.Services/ListRequestHandler-3.TListResponse.md)
* interface [IListRequestProcessor](IListRequestProcessor.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [ListRequest](ListRequest.md)
* class [ListResponse&lt;T&gt;](ListResponse-1.md)
* **Source:** *[ListRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/ListRequestHandler.cs)*