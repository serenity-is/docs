# DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for delete request handlers

```csharp
public class DeleteRequestHandler<TRow, TDeleteRequest, TDeleteResponse> : 
    IDeleteHandler<TRow, TDeleteRequest, TDeleteResponse>, IDeleteRequestProcessor
    where TRow : class, IRow, IIdRow, new()
    where TDeleteRequest : DeleteRequest
    where TDeleteResponse : DeleteResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TDeleteRequest | Delete request type |
| TDeleteResponse | Delete response type |

## Public Members

| name | description |
| --- | --- |
| [DeleteRequestHandler](DeleteRequestHandler-3/DeleteRequestHandler.md)(…) | Creates an instance of the class |
| [Cache](DeleteRequestHandler-3/Cache.md) { get; } | Gets the two level cache from the request context |
| [Connection](DeleteRequestHandler-3/Connection.md) { get; } | Gets current connection from the unit of work |
| [Context](DeleteRequestHandler-3/Context.md) { get; } | Gets the request context |
| [Localizer](DeleteRequestHandler-3/Localizer.md) { get; } | Gets localizer from the request context |
| [Permissions](DeleteRequestHandler-3/Permissions.md) { get; } | Gets permission service from the request context |
| [StateBag](DeleteRequestHandler-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [UnitOfWork](DeleteRequestHandler-3/UnitOfWork.md) { get; protected set; } | Gets current unit of work |
| [User](DeleteRequestHandler-3/User.md) { get; } | Gets current user from the request context |
| [Delete](DeleteRequestHandler-3/Delete.md)(…) |  |
| [Process](DeleteRequestHandler-3/Process.md)(…) | Processes the delete request. This is the entry point for the handler. |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](DeleteRequestHandler-3/behaviors-.md) | Lazy list of behaviors that is activated for this request |
| [Request](DeleteRequestHandler-3/Request.md) | Request object |
| [Response](DeleteRequestHandler-3/Response.md) | Response object |
| [Row](DeleteRequestHandler-3/Row.md) | The entity |
| virtual [DoAudit](DeleteRequestHandler-3/DoAudit.md)() | Performs auditing |
| virtual [ExecuteDelete](DeleteRequestHandler-3/ExecuteDelete.md)() | Executes the actual SQL delete operation |
| virtual [GetBehaviors](DeleteRequestHandler-3/GetBehaviors.md)() | Gets the list of delete behaviors |
| virtual [GetDisplayOrderFilter](DeleteRequestHandler-3/GetDisplayOrderFilter.md)() | Gets the display order filter for current group, if the entity implements IDisplayOrderRow interface |
| virtual [InvalidateCacheOnCommit](DeleteRequestHandler-3/InvalidateCacheOnCommit.md)() | Attaches a cache invalidation call to to OnCommit callback of the current unit of work. This would clear cached items related to this row type. |
| virtual [InvokeDeleteAction](DeleteRequestHandler-3/InvokeDeleteAction.md)(…) | Invokes the passed delete action method |
| virtual [IsDeleted](DeleteRequestHandler-3/IsDeleted.md)() | Checks if the entity is already deleted |
| virtual [LoadEntity](DeleteRequestHandler-3/LoadEntity.md)() | Loads the entity that is going to be deleted |
| virtual [OnAfterDelete](DeleteRequestHandler-3/OnAfterDelete.md)() | Method that is executed after the actual SQL delete operation |
| virtual [OnBeforeDelete](DeleteRequestHandler-3/OnBeforeDelete.md)() | Method that is executed before the actual SQL delete operation. |
| virtual [OnReturn](DeleteRequestHandler-3/OnReturn.md)() | The method that is called just before the response is returned. |
| virtual [PrepareQuery](DeleteRequestHandler-3/PrepareQuery.md)(…) | Prepares the query used to select the existing record |
| virtual [ValidatePermissions](DeleteRequestHandler-3/ValidatePermissions.md)() | Validates the user permissions for delete operation |
| virtual [ValidateRequest](DeleteRequestHandler-3/ValidateRequest.md)() | Validates the parameters of the delete request. |

## See Also

* interface [IDeleteHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](IDeleteHandler-3.md)
* class [TRow](../Serenity.Net.Services/DeleteRequestHandler-3.TRow.md)
* class [TDeleteRequest](../Serenity.Net.Services/DeleteRequestHandler-3.TDeleteRequest.md)
* class [TDeleteResponse](../Serenity.Net.Services/DeleteRequestHandler-3.TDeleteResponse.md)
* interface [IDeleteRequestProcessor](IDeleteRequestProcessor.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* class [DeleteRequest](DeleteRequest.md)
* class [DeleteResponse](DeleteResponse.md)
* **Source:** *[DeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/DeleteRequestHandler.cs)*