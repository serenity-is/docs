# RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for retrieve request handlers

```csharp
public class RetrieveRequestHandler<TRow, TRetrieveRequest, TRetrieveResponse> : 
    IRetrieveHandler<TRow, TRetrieveRequest, TRetrieveResponse>, IRetrieveRequestProcessor
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
| [RetrieveRequestHandler](RetrieveRequestHandler-3/RetrieveRequestHandler.md)(…) | Creates an instance of the class |
| [Cache](RetrieveRequestHandler-3/Cache.md) { get; } | Gets the two level cache from the request context |
| [Connection](RetrieveRequestHandler-3/Connection.md) { get; } | Gets current connection |
| [Context](RetrieveRequestHandler-3/Context.md) { get; } | Gets the request context |
| [Localizer](RetrieveRequestHandler-3/Localizer.md) { get; } | Gets localizer from the request context |
| [Permissions](RetrieveRequestHandler-3/Permissions.md) { get; } | Gets permission service from the request context |
| [Query](RetrieveRequestHandler-3/Query.md) { get; } | Gets the select query |
| [Request](RetrieveRequestHandler-3/Request.md) { get; protected set; } | Response object |
| [Response](RetrieveRequestHandler-3/Response.md) { get; protected set; } | Response object |
| [Row](RetrieveRequestHandler-3/Row.md) { get; protected set; } | The entity used for querying / metadata lookup |
| [StateBag](RetrieveRequestHandler-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [User](RetrieveRequestHandler-3/User.md) { get; } | Gets current user from the request context |
| [Process](RetrieveRequestHandler-3/Process.md)(…) | Processes the retrieve request. This is the entry point for the handler. |
| [Retrieve](RetrieveRequestHandler-3/Retrieve.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](RetrieveRequestHandler-3/behaviors-.md) | Lazy list of behaviors that is activated for this request |
| virtual [AllowSelectField](RetrieveRequestHandler-3/AllowSelectField.md)(…) | Returns true if the field should be allowed to be selected, based on is read permission, selectlevel.never flag, and lookup access mode |
| virtual [CreateQuery](RetrieveRequestHandler-3/CreateQuery.md)() | Creates a query instance with the dialect for current connection. |
| virtual [GetBehaviors](RetrieveRequestHandler-3/GetBehaviors.md)() | Gets the list of retrieve behaviors |
| [IsIncluded](RetrieveRequestHandler-3/IsIncluded.md)(…) | Returns true if field is included in [`IncludeColumns`](RetrieveRequest/IncludeColumns.md) (2 methods) |
| virtual [OnAfterExecuteQuery](RetrieveRequestHandler-3/OnAfterExecuteQuery.md)() | Called after executing the retrieve query |
| virtual [OnBeforeExecuteQuery](RetrieveRequestHandler-3/OnBeforeExecuteQuery.md)() | Called before executing the retrieve query |
| virtual [OnReturn](RetrieveRequestHandler-3/OnReturn.md)() | Called just before returning the response |
| virtual [PrepareQuery](RetrieveRequestHandler-3/PrepareQuery.md)(…) | Prepares query by calling [`SelectFields`](RetrieveRequestHandler-3/SelectFields.md). |
| virtual [SelectField](RetrieveRequestHandler-3/SelectField.md)(…) | Calls query.Select(field) |
| virtual [SelectFields](RetrieveRequestHandler-3/SelectFields.md)(…) | Calls query.Select(field) for all the fields without NotMapped, and if [`AllowSelectField`](RetrieveRequestHandler-3/AllowSelectField.md) and [`ShouldSelectField`](RetrieveRequestHandler-3/ShouldSelectField.md) returns true. |
| virtual [ShouldSelectField](RetrieveRequestHandler-3/ShouldSelectField.md)(…) | Returns true if the field should be selected, based on current ColumnSelection, field MinSelectLevelAttribute, the field being a not mapped (NotMappedAttribute) field, table field, or a view / expression field. |
| virtual [ValidatePermissions](RetrieveRequestHandler-3/ValidatePermissions.md)() | Validates if the user is allowed to query this entity type by checking ReadPermissionAttribute and ServiceLookupPermissionAttribute if the request is in lookup access mode. |
| virtual [ValidateRequest](RetrieveRequestHandler-3/ValidateRequest.md)() | Validates the request by calling [`ValidatePermissions`](RetrieveRequestHandler-3/ValidatePermissions.md) |

## See Also

* interface [IRetrieveHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](IRetrieveHandler-3.md)
* class [TRow](../Serenity.Net.Services/RetrieveRequestHandler-3.TRow.md)
* class [TRetrieveRequest](../Serenity.Net.Services/RetrieveRequestHandler-3.TRetrieveRequest.md)
* class [TRetrieveResponse](../Serenity.Net.Services/RetrieveRequestHandler-3.TRetrieveResponse.md)
* interface [IRetrieveRequestProcessor](IRetrieveRequestProcessor.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* **Source:** *[RetrieveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Retrieve/RetrieveRequestHandler.cs)*