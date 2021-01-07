# UndeleteRequestHandler&lt;TRow,TUndeleteResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class UndeleteRequestHandler<TRow, TUndeleteResponse>
    where TRow : class, IRow, IIdRow, new()
    where TUndeleteResponse : UndeleteResponse, new()
```

## Public Members

| name | description |
| --- | --- |
| [UndeleteRequestHandler](UndeleteRequestHandler-2/UndeleteRequestHandler.md)(…) |  |
| [Cache](UndeleteRequestHandler-2/Cache.md) { get; } |  |
| [Context](UndeleteRequestHandler-2/Context.md) { get; } |  |
| [Localizer](UndeleteRequestHandler-2/Localizer.md) { get; } |  |
| [Permissions](UndeleteRequestHandler-2/Permissions.md) { get; } |  |
| [User](UndeleteRequestHandler-2/User.md) { get; } |  |
| [Process](UndeleteRequestHandler-2/Process.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [Connection](UndeleteRequestHandler-2/Connection.md) { get; } |  |
| [behaviors-](UndeleteRequestHandler-2/behaviors-.md) |  |
| [Request](UndeleteRequestHandler-2/Request.md) |  |
| [Response](UndeleteRequestHandler-2/Response.md) |  |
| [Row](UndeleteRequestHandler-2/Row.md) |  |
| [UnitOfWork](UndeleteRequestHandler-2/UnitOfWork.md) |  |
| virtual [DoAudit](UndeleteRequestHandler-2/DoAudit.md)() |  |
| virtual [DoCaptureLog](UndeleteRequestHandler-2/DoCaptureLog.md)() |  |
| virtual [GetDisplayOrderFilter](UndeleteRequestHandler-2/GetDisplayOrderFilter.md)() |  |
| virtual [InvalidateCacheOnCommit](UndeleteRequestHandler-2/InvalidateCacheOnCommit.md)() |  |
| virtual [LoadEntity](UndeleteRequestHandler-2/LoadEntity.md)() |  |
| virtual [OnAfterUndelete](UndeleteRequestHandler-2/OnAfterUndelete.md)() |  |
| virtual [OnBeforeUndelete](UndeleteRequestHandler-2/OnBeforeUndelete.md)() |  |
| virtual [OnReturn](UndeleteRequestHandler-2/OnReturn.md)() |  |
| virtual [PrepareQuery](UndeleteRequestHandler-2/PrepareQuery.md)(…) |  |
| virtual [ValidatePermissions](UndeleteRequestHandler-2/ValidatePermissions.md)() |  |
| virtual [ValidateRequest](UndeleteRequestHandler-2/ValidateRequest.md)() |  |

## See Also

* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* class [UndeleteResponse](UndeleteResponse.md)
* **Source:** *[UndeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/UndeleteRequestHandler.cs)*