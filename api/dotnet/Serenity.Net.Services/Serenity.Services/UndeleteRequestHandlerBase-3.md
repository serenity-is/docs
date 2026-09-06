# UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstract base class for undelete request handlers that share state and mode neutral helper methods between synchronous and asynchronous undelete request handlers.

```csharp
public abstract class UndeleteRequestHandlerBase<TRow, TUndeleteRequest, TUndeleteResponse> : 
    IUndeleteRequestHandler
    where TRow : class, IRow, IIdRow, new()
    where TUndeleteRequest : UndeleteRequest
    where TUndeleteResponse : UndeleteResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TUndeleteRequest | Undelete request type |
| TUndeleteResponse | Undelete response type |

## Public Members

| name | description |
| --- | --- |
| [Cache](UndeleteRequestHandlerBase-3/Cache.md) { get; } | Gets the two level cache from the request context. |
| [Connection](UndeleteRequestHandlerBase-3/Connection.md) { get; } | Gets the current connection. |
| [Context](UndeleteRequestHandlerBase-3/Context.md) { get; } | Gets the request context. |
| [Localizer](UndeleteRequestHandlerBase-3/Localizer.md) { get; } | Gets the localizer from the request context. |
| [Permissions](UndeleteRequestHandlerBase-3/Permissions.md) { get; } | Gets the permission service from the request context. |
| [Request](UndeleteRequestHandlerBase-3/Request.md) { get; protected set; } | Gets the request object. |
| [Response](UndeleteRequestHandlerBase-3/Response.md) { get; protected set; } | Gets the response object. |
| [Row](UndeleteRequestHandlerBase-3/Row.md) { get; protected set; } | Gets the entity being undeleted. |
| [StateBag](UndeleteRequestHandlerBase-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [UnitOfWork](UndeleteRequestHandlerBase-3/UnitOfWork.md) { get; protected set; } | Gets the current unit of work. |
| [User](UndeleteRequestHandlerBase-3/User.md) { get; } | Gets the current user from the request context. |

## Protected Members

| name | description |
| --- | --- |
| [UndeleteRequestHandlerBase](UndeleteRequestHandlerBase-3/UndeleteRequestHandlerBase.md)(…) | Initializes a new instance of the class. |
| virtual [GetBehaviors](UndeleteRequestHandlerBase-3/GetBehaviors.md)() | Gets the list of undelete behaviors. |
| virtual [GetDisplayOrderFilter](UndeleteRequestHandlerBase-3/GetDisplayOrderFilter.md)() | Gets the display order filter for current group, if the entity implements [`IDisplayOrderRow`](../Serenity.Data/IDisplayOrderRow.md) interface |
| virtual [InvalidateCacheOnCommit](UndeleteRequestHandlerBase-3/InvalidateCacheOnCommit.md)() | Attaches a cache invalidation call to to OnCommit callback of the current unit of work. This would clear cached items related to this row type. |
| virtual [IsDeleted](UndeleteRequestHandlerBase-3/IsDeleted.md)() | Checks that row type implements one of IIsActiveDeletedRow, IIsDeletedRow or IDeleteLogRow interfaces and it is actual marked as deleted |
| virtual [ValidatePermissions](UndeleteRequestHandlerBase-3/ValidatePermissions.md)() | Validates the user permissions for undelete operation |

## See Also

* interface [IUndeleteRequestHandler](IUndeleteRequestHandler.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* **Source:** *[UndeleteRequestHandlerBase.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/UndeleteRequestHandlerBase.cs)*