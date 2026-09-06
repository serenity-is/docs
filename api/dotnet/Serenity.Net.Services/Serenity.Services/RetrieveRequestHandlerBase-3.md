# RetrieveRequestHandlerBase&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstract base class for retrieve request handlers that share state and mode neutral helper methods between synchronous and asynchronous retrieve request handlers.

```csharp
public abstract class RetrieveRequestHandlerBase<TRow, TRetrieveRequest, TRetrieveResponse> : 
    IRetrieveRequestHandler
    where TRow : class, IRow, new()
    where TRetrieveRequest : RetrieveRequest
    where TRetrieveResponse : RetrieveResponse<TRow>, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TRetrieveRequest | Retrieve request type |
| TRetrieveResponse | Retrieve response type |

## Public Members

| name | description |
| --- | --- |
| [Cache](RetrieveRequestHandlerBase-3/Cache.md) { get; } | Gets the two level cache from the request context. |
| [Connection](RetrieveRequestHandlerBase-3/Connection.md) { get; protected set; } | Gets the current connection. |
| [Context](RetrieveRequestHandlerBase-3/Context.md) { get; } | Gets the request context. |
| [Localizer](RetrieveRequestHandlerBase-3/Localizer.md) { get; } | Gets the localizer from the request context. |
| [Permissions](RetrieveRequestHandlerBase-3/Permissions.md) { get; } | Gets the permission service from the request context. |
| [Query](RetrieveRequestHandlerBase-3/Query.md) { get; protected set; } | Gets the select query. |
| [Request](RetrieveRequestHandlerBase-3/Request.md) { get; protected set; } | Gets the request object. |
| [Response](RetrieveRequestHandlerBase-3/Response.md) { get; protected set; } | Gets the response object. |
| [Row](RetrieveRequestHandlerBase-3/Row.md) { get; protected set; } | Gets the entity used for querying / metadata lookup. |
| [StateBag](RetrieveRequestHandlerBase-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [User](RetrieveRequestHandlerBase-3/User.md) { get; } | Gets the current user from the request context. |

## Protected Members

| name | description |
| --- | --- |
| [RetrieveRequestHandlerBase](RetrieveRequestHandlerBase-3/RetrieveRequestHandlerBase.md)(…) | Initializes a new instance of the class. |
| virtual [AllowSelectField](RetrieveRequestHandlerBase-3/AllowSelectField.md)(…) | Returns true if the field should be allowed to be selected, based on its read permission and the SelectLevel.Never flag. |
| virtual [CreateQuery](RetrieveRequestHandlerBase-3/CreateQuery.md)() | Creates a query instance with the dialect for current connection. |
| virtual [GetBehaviors](RetrieveRequestHandlerBase-3/GetBehaviors.md)() | Gets the list of retrieve behaviors. |
| [IsIncluded](RetrieveRequestHandlerBase-3/IsIncluded.md)(…) | Returns true if field is included in [`IncludeColumns`](RetrieveRequest/IncludeColumns.md) (2 methods) |
| virtual [SelectField](RetrieveRequestHandlerBase-3/SelectField.md)(…) | Calls query.Select(field) |
| virtual [SelectFields](RetrieveRequestHandlerBase-3/SelectFields.md)(…) | Calls query.Select(field) for all the fields without NotMapped, and if [`AllowSelectField`](RetrieveRequestHandlerBase-3/AllowSelectField.md) and [`ShouldSelectField`](RetrieveRequestHandlerBase-3/ShouldSelectField.md) returns true. |
| virtual [ShouldSelectField](RetrieveRequestHandlerBase-3/ShouldSelectField.md)(…) | Returns true if the field should be selected, based on current ColumnSelection, field [`MinSelectLevelAttribute`](../Serenity.Data.Mapping/MinSelectLevelAttribute.md), the field being a not mapped ([`NotMappedAttribute`](../Serenity.Data.Mapping/NotMappedAttribute.md)) field, table field, or a view / expression field. |
| virtual [ValidatePermissions](RetrieveRequestHandlerBase-3/ValidatePermissions.md)() | Validates if the user is allowed to query this entity type by checking ReadPermissionAttribute and ServiceLookupPermissionAttribute if the request is in lookup access mode. |

## See Also

* interface [IRetrieveRequestHandler](IRetrieveRequestHandler.md)
* interface [IRow](../Serenity.Data/IRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* class [TRow](../Serenity.Net.Services/RetrieveRequestHandlerBase-3.TRow.md)
* **Source:** *[RetrieveRequestHandlerBase.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/RetrieveRequestHandlerBase.cs)*