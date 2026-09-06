# DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstract base class for delete request handlers that share state and mode neutral helper methods between synchronous and asynchronous delete request handlers.

```csharp
public abstract class DeleteRequestHandlerBase<TRow, TDeleteRequest, TDeleteResponse> : 
    IDeleteRequestHandler
    where TRow : class, IRow, IIdRow, new()
    where TDeleteRequest : DeleteRequest
    where TDeleteResponse : DeleteResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TDeleteRequest | Delete request type |
| TDeleteResponse | Delete response type |
| context | Request context |

## Public Members

| name | description |
| --- | --- |
| [Cache](DeleteRequestHandlerBase-3/Cache.md) { get; } | Gets the two level cache from the request context. |
| [Connection](DeleteRequestHandlerBase-3/Connection.md) { get; } | Gets the current connection. |
| [Context](DeleteRequestHandlerBase-3/Context.md) { get; } | Gets the request context. |
| [Localizer](DeleteRequestHandlerBase-3/Localizer.md) { get; } | Gets the localizer from the request context. |
| [Permissions](DeleteRequestHandlerBase-3/Permissions.md) { get; } | Gets the permission service from the request context. |
| [Request](DeleteRequestHandlerBase-3/Request.md) { get; protected set; } | Gets the request object. |
| [Response](DeleteRequestHandlerBase-3/Response.md) { get; protected set; } | Gets the response object. |
| [Row](DeleteRequestHandlerBase-3/Row.md) { get; protected set; } | Gets the entity being deleted. |
| [StateBag](DeleteRequestHandlerBase-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [UnitOfWork](DeleteRequestHandlerBase-3/UnitOfWork.md) { get; protected set; } | Gets the current unit of work. |
| [User](DeleteRequestHandlerBase-3/User.md) { get; } | Gets the current user from the request context. |

## Protected Members

| name | description |
| --- | --- |
| [DeleteRequestHandlerBase](DeleteRequestHandlerBase-3/DeleteRequestHandlerBase.md)(…) | Abstract base class for delete request handlers that share state and mode neutral helper methods between synchronous and asynchronous delete request handlers. |
| virtual [GetBehaviors](DeleteRequestHandlerBase-3/GetBehaviors.md)() | Gets the list of delete behaviors. |
| virtual [GetDisplayOrderFilter](DeleteRequestHandlerBase-3/GetDisplayOrderFilter.md)() | Gets the display order filter for current group, if the entity implements [`IDisplayOrderRow`](../Serenity.Data/IDisplayOrderRow.md) interface |
| virtual [InvalidateCacheOnCommit](DeleteRequestHandlerBase-3/InvalidateCacheOnCommit.md)() | Attaches a cache invalidation call to to OnCommit callback of the current unit of work. This would clear cached items related to this row type. |
| virtual [IsDeleted](DeleteRequestHandlerBase-3/IsDeleted.md)() | Checks if the entity is already deleted |
| virtual [ValidatePermissions](DeleteRequestHandlerBase-3/ValidatePermissions.md)() | Validates the user permissions for delete operation |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IDeleteRequestHandler](./IDeleteRequestHandler.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [DeleteRequest](./DeleteRequest.md)
* class [DeleteResponse](./DeleteResponse.md)
* **Source:** *[DeleteRequestHandlerBase.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/DeleteRequestHandlerBase.cs)*