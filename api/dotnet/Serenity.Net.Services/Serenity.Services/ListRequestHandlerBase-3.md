# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstract base class for list request handlers that share state and mode neutral helper methods between synchronous and asynchronous list request handlers.

```csharp
public abstract class ListRequestHandlerBase<TRow, TListRequest, TListResponse> : 
    IListRequestHandler
    where TRow : class, IRow, new()
    where TListRequest : ListRequest
    where TListResponse : ListResponse<TRow>, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TListRequest | List request type |
| TListResponse | List response type |
| context | Request context |

## Public Members

| name | description |
| --- | --- |
| [Cache](ListRequestHandlerBase-3/Cache.md) { get; } | Gets the two level cache from the request context. |
| [Connection](ListRequestHandlerBase-3/Connection.md) { get; protected set; } | Gets the current connection. |
| [Context](ListRequestHandlerBase-3/Context.md) { get; } | Gets the request context. |
| [DistinctFields](ListRequestHandlerBase-3/DistinctFields.md) { get; protected set; } | Gets the list of distinct fields. |
| [Localizer](ListRequestHandlerBase-3/Localizer.md) { get; } | Gets the localizer from the request context. |
| [Permissions](ListRequestHandlerBase-3/Permissions.md) { get; } | Gets the permission service from the request context. |
| [Query](ListRequestHandlerBase-3/Query.md) { get; protected set; } | Gets the select query. |
| [Request](ListRequestHandlerBase-3/Request.md) { get; protected set; } | Gets the request object. |
| [Response](ListRequestHandlerBase-3/Response.md) { get; protected set; } | Gets the response object. |
| [Row](ListRequestHandlerBase-3/Row.md) { get; protected set; } | Gets the entity used for querying / metadata lookup. |
| [StateBag](ListRequestHandlerBase-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [User](ListRequestHandlerBase-3/User.md) { get; } | Gets the current user from the request context. |
| [GetDistinctFields](ListRequestHandlerBase-3/GetDistinctFields.md)() | Gets an array of distinct fields by checking Request.DistinctFields. It might be different than the passed list, if the list contains an invalid field or a field that is not allowed to be selected, like NotMapped and Never etc. |
| [IgnoreEqualityFilter](ListRequestHandlerBase-3/IgnoreEqualityFilter.md)(…) | Adds the field to the list of ignored equality filters, so that having this field in the Request.EqualityFilter won't raise an exception |

## Protected Members

| name | description |
| --- | --- |
| [ListRequestHandlerBase](ListRequestHandlerBase-3/ListRequestHandlerBase.md)(…) | Abstract base class for list request handlers that share state and mode neutral helper methods between synchronous and asynchronous list request handlers. |
| [ignoredEqualityFilters](ListRequestHandlerBase-3/ignoredEqualityFilters.md) | Set of ignored equality filter entries. |
| [lookupAccessMode](ListRequestHandlerBase-3/lookupAccessMode.md) | True if the list handler is in lookup access mode, e.g. it only allows access to lookup fields. |
| virtual [AddFieldContainsCriteria](ListRequestHandlerBase-3/AddFieldContainsCriteria.md)(…) | Applies a contains criteria based on containsText, id (if the contains text can be parsed to an integer ID), searchType and numericOnly parameters. |
| virtual [AllowSelectField](ListRequestHandlerBase-3/AllowSelectField.md)(…) | Returns true if the field should be allowed to be selected, based on is read permission, selectlevel.never flag, and lookup access mode |
| virtual [ApplyContainsText](ListRequestHandlerBase-3/ApplyContainsText.md)(…) | Applies contains text filter to the query |
| virtual [ApplyCriteria](ListRequestHandlerBase-3/ApplyCriteria.md)(…) | Applies the Request.Criteria to the query if it is not null or empty, and replaced field references with their corresponding expressions by calling [`ReplaceFieldExpressions`](./ListRequestHandlerBase-3/ReplaceFieldExpressions.md) |
| virtual [ApplyEqualityFilter](ListRequestHandlerBase-3/ApplyEqualityFilter.md)(…) | Applies the Request.Equality filter to the query |
| virtual [ApplyFieldContainsText](ListRequestHandlerBase-3/ApplyFieldContainsText.md)(…) | Applies a field contains criteria to the query by calling [`AddFieldContainsCriteria`](./ListRequestHandlerBase-3/AddFieldContainsCriteria.md) |
| virtual [ApplyFieldEqualityFilter](ListRequestHandlerBase-3/ApplyFieldEqualityFilter.md)(…) | Applies a field equality filter, e.g. one that is passed via Request.EqualityFilter to the query. It validates field flags like DenyFiltering and NotMapped and Never to check if the field is allowed to be filtered. |
| virtual [ApplyIncludeDeletedFilter](ListRequestHandlerBase-3/ApplyIncludeDeletedFilter.md)(…) | Applies include deleted filter to the query if Request.IncludeDeleted is true |
| virtual [ApplyKeyOrder](ListRequestHandlerBase-3/ApplyKeyOrder.md)(…) | Applies the key order which is ID field ([`IIdRow`](../Serenity.Data/IIdRow.md)) |
| virtual [ApplySort](ListRequestHandlerBase-3/ApplySort.md)(…) | Applies the Request.Sort order to the query. Sorts by [`GetNativeSort`](./ListRequestHandlerBase-3/GetNativeSort.md) if no sort columns are passed, or the list is empty. |
| virtual [ApplySortBy](ListRequestHandlerBase-3/ApplySortBy.md)(…) | Applies a sort order to the query |
| virtual [CreateQuery](ListRequestHandlerBase-3/CreateQuery.md)() | Creates a query instance with the dialect for current connection. |
| virtual [GetBehaviors](ListRequestHandlerBase-3/GetBehaviors.md)() | Gets the list of list behaviors. |
| virtual [GetNativeSort](ListRequestHandlerBase-3/GetNativeSort.md)() | Gets the native sort order, which includes name field by default, unless the row has [SortOrder] attributes. |
| virtual [GetQuickSearchFields](ListRequestHandlerBase-3/GetQuickSearchFields.md)(…) | Gets the list of quick search fields ([`QuickSearchAttribute`](../Serenity.Data.Mapping/QuickSearchAttribute.md)) based on the containsField argument. |
| [IsEmptyEqualityFilterValue](ListRequestHandlerBase-3/IsEmptyEqualityFilterValue.md)(…) | Checks if the equality filter value is empty. It returns true for null, empty string, or empty IEnumerable. |
| [IsIncluded](ListRequestHandlerBase-3/IsIncluded.md)(…) | Returns true if field is included in [`IncludeColumns`](./ListRequest/IncludeColumns.md) (2 methods) |
| abstract [MapFieldExpression](ListRequestHandlerBase-3/MapFieldExpression.md)(…) | Maps a field using IListFieldMappingBehavior's if any |
| virtual [ProcessEntity](ListRequestHandlerBase-3/ProcessEntity.md)(…) | Can be overridden in a derived class to make some changes in a returned entity just before it gets added to the Response.Entities list. |
| virtual [ReplaceFieldExpressions](ListRequestHandlerBase-3/ReplaceFieldExpressions.md)(…) | Replaces field references, e.g. property names and field name with their corresponding expression by using the [`CriteriaFieldExpressionReplacer`](../Serenity.Data/CriteriaFieldExpressionReplacer.md) |
| virtual [SelectField](ListRequestHandlerBase-3/SelectField.md)(…) | Calls query.Select(field) |
| virtual [SelectFields](ListRequestHandlerBase-3/SelectFields.md)(…) | Calls query.Select(field) for all the fields without NotMapped, and if [`AllowSelectField`](./ListRequestHandlerBase-3/AllowSelectField.md) and [`ShouldSelectField`](./ListRequestHandlerBase-3/ShouldSelectField.md) returns true. |
| virtual [ShouldSelectField](ListRequestHandlerBase-3/ShouldSelectField.md)(…) | Returns true if the field should be selected, based on current ColumnSelection, field [`MinSelectLevelAttribute`](../Serenity.Data.Mapping/MinSelectLevelAttribute.md), the field being a not mapped ([`NotMappedAttribute`](../Serenity.Data.Mapping/NotMappedAttribute.md)) field, table field, or a view / expression field. |
| virtual [ToCriteria](ListRequestHandlerBase-3/ToCriteria.md)(…) | Converts the field to criteria, using IListFieldMappingBehavior's if any |
| virtual [ValidatePermissions](ListRequestHandlerBase-3/ValidatePermissions.md)() | Validates if the user is allowed to query this entity type by checking ReadPermissionAttribute and ServiceLookupPermissionAttribute if the request is in lookup access mode. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IListRequestHandler](./IListRequestHandler.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [ListRequest](./ListRequest.md)
* class [ListResponse&lt;T&gt;](./ListResponse-1.md)
* **Source:** *[ListRequestHandlerBase.cs](https://github.com/serenity-is/Serenity/blob/62e26a99abba7fd00c7409a1334581e3c5ccd1f4/src/services/RequestHandlers/List/ListRequestHandlerBase.cs)*