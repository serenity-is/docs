# UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for undelete request handlers

```csharp
public class UndeleteRequestHandler<TRow, TUndeleteRequest, TUndeleteResponse> : 
    IUndeleteHandler<TRow, TUndeleteRequest, TUndeleteResponse>, IUndeleteRequestProcessor
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
| [UndeleteRequestHandler](UndeleteRequestHandler-3/UndeleteRequestHandler.md)(…) | Creates an instance of the class |
| [Cache](UndeleteRequestHandler-3/Cache.md) { get; } | Gets the two level cache from the request context |
| [Connection](UndeleteRequestHandler-3/Connection.md) { get; } | Gets current connection from the unit of work |
| [Context](UndeleteRequestHandler-3/Context.md) { get; } | Gets the request context |
| [Localizer](UndeleteRequestHandler-3/Localizer.md) { get; } | Gets localizer from the request context |
| [Permissions](UndeleteRequestHandler-3/Permissions.md) { get; } | Gets permission service from the request context |
| [Request](UndeleteRequestHandler-3/Request.md) { get; protected set; } | Request object |
| [Response](UndeleteRequestHandler-3/Response.md) { get; protected set; } | Response object |
| [Row](UndeleteRequestHandler-3/Row.md) { get; protected set; } | The entity |
| [StateBag](UndeleteRequestHandler-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [UnitOfWork](UndeleteRequestHandler-3/UnitOfWork.md) { get; protected set; } | Gets current unit of work |
| [User](UndeleteRequestHandler-3/User.md) { get; } | Gets current user from the request context |
| [Process](UndeleteRequestHandler-3/Process.md)(…) | Processes the undelete request. This is the entry point for the handler. |
| [Undelete](UndeleteRequestHandler-3/Undelete.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](UndeleteRequestHandler-3/behaviors-.md) | Lazy list of behaviors that is activated for this request |
| virtual [DoAudit](UndeleteRequestHandler-3/DoAudit.md)() | Performs auditing |
| virtual [ExecuteUndelete](UndeleteRequestHandler-3/ExecuteUndelete.md)() | Executes the actual SQL undelete/update operation |
| virtual [GetBehaviors](UndeleteRequestHandler-3/GetBehaviors.md)() | Gets the list of undelete behaviors |
| virtual [GetDisplayOrderFilter](UndeleteRequestHandler-3/GetDisplayOrderFilter.md)() | Gets the display order filter for current group, if the entity implements IDisplayOrderRow interface |
| virtual [InvalidateCacheOnCommit](UndeleteRequestHandler-3/InvalidateCacheOnCommit.md)() | Attaches a cache invalidation call to to OnCommit callback of the current unit of work. This would clear cached items related to this row type. |
| virtual [InvokeUndeleteAction](UndeleteRequestHandler-3/InvokeUndeleteAction.md)(…) | Invokes the passed undelete action method |
| virtual [IsDeleted](UndeleteRequestHandler-3/IsDeleted.md)() | Checks that row type implements one of IIsActiveDeletedRow, IIsDeletedRow or IDeleteLogRow interfaces and it is actual marked as deleted |
| virtual [LoadEntity](UndeleteRequestHandler-3/LoadEntity.md)() | Loads the entity that is going to be undeleted |
| virtual [OnAfterUndelete](UndeleteRequestHandler-3/OnAfterUndelete.md)() | Method that is executed after the actual SQL undelete operation |
| virtual [OnBeforeUndelete](UndeleteRequestHandler-3/OnBeforeUndelete.md)() | Method that is executed before the actual SQL undelete operation. |
| virtual [OnReturn](UndeleteRequestHandler-3/OnReturn.md)() | The method that is called just before the response is returned. |
| virtual [PrepareQuery](UndeleteRequestHandler-3/PrepareQuery.md)(…) | Prepares the query used to select the existing record |
| virtual [ValidatePermissions](UndeleteRequestHandler-3/ValidatePermissions.md)() | Validates the user permissions for undelete operation |
| virtual [ValidateRequest](UndeleteRequestHandler-3/ValidateRequest.md)() | Validates the parameters of the undelete request. |

## See Also

* interface [IUndeleteHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](IUndeleteHandler-3.md)
* class [TRow](../Serenity.Net.Services/UndeleteRequestHandler-3.TRow.md)
* class [TUndeleteRequest](../Serenity.Net.Services/UndeleteRequestHandler-3.TUndeleteRequest.md)
* class [TUndeleteResponse](../Serenity.Net.Services/UndeleteRequestHandler-3.TUndeleteResponse.md)
* interface [IUndeleteRequestProcessor](IUndeleteRequestProcessor.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* class [UndeleteRequest](UndeleteRequest.md)
* class [UndeleteResponse](UndeleteResponse.md)
* **Source:** *[UndeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Undelete/UndeleteRequestHandler.cs)*