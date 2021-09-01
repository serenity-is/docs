# DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class DeleteRequestHandler<TRow, TDeleteRequest, TDeleteResponse> : 
    IDeleteHandler<TRow, TDeleteRequest, TDeleteResponse>, IDeleteRequestProcessor
    where TRow : class, IRow, IIdRow, new()
    where TDeleteRequest : DeleteRequest
    where TDeleteResponse : DeleteResponse, new()
```

## Public Members

| name | description |
| --- | --- |
| [DeleteRequestHandler](DeleteRequestHandler-3/DeleteRequestHandler.md)(…) |  |
| [Cache](DeleteRequestHandler-3/Cache.md) { get; } |  |
| [Connection](DeleteRequestHandler-3/Connection.md) { get; } |  |
| [Context](DeleteRequestHandler-3/Context.md) { get; } |  |
| [Localizer](DeleteRequestHandler-3/Localizer.md) { get; } |  |
| [Permissions](DeleteRequestHandler-3/Permissions.md) { get; } |  |
| [StateBag](DeleteRequestHandler-3/StateBag.md) { get; } |  |
| [UnitOfWork](DeleteRequestHandler-3/UnitOfWork.md) { get; protected set; } |  |
| [User](DeleteRequestHandler-3/User.md) { get; } |  |
| [Delete](DeleteRequestHandler-3/Delete.md)(…) |  |
| [Process](DeleteRequestHandler-3/Process.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](DeleteRequestHandler-3/behaviors-.md) |  |
| [Request](DeleteRequestHandler-3/Request.md) |  |
| [Response](DeleteRequestHandler-3/Response.md) |  |
| [Row](DeleteRequestHandler-3/Row.md) |  |
| virtual [DoAudit](DeleteRequestHandler-3/DoAudit.md)() |  |
| virtual [ExecuteDelete](DeleteRequestHandler-3/ExecuteDelete.md)() |  |
| virtual [GetBehaviors](DeleteRequestHandler-3/GetBehaviors.md)() |  |
| virtual [GetDisplayOrderFilter](DeleteRequestHandler-3/GetDisplayOrderFilter.md)() |  |
| virtual [InvalidateCacheOnCommit](DeleteRequestHandler-3/InvalidateCacheOnCommit.md)() |  |
| virtual [InvokeDeleteAction](DeleteRequestHandler-3/InvokeDeleteAction.md)(…) |  |
| virtual [LoadEntity](DeleteRequestHandler-3/LoadEntity.md)() |  |
| virtual [OnAfterDelete](DeleteRequestHandler-3/OnAfterDelete.md)() |  |
| virtual [OnBeforeDelete](DeleteRequestHandler-3/OnBeforeDelete.md)() |  |
| virtual [OnReturn](DeleteRequestHandler-3/OnReturn.md)() |  |
| virtual [PrepareQuery](DeleteRequestHandler-3/PrepareQuery.md)(…) |  |
| virtual [ValidatePermissions](DeleteRequestHandler-3/ValidatePermissions.md)() |  |
| virtual [ValidateRequest](DeleteRequestHandler-3/ValidateRequest.md)() |  |

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