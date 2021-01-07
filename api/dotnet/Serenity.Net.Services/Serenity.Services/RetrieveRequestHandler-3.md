# RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class RetrieveRequestHandler<TRow, TRetrieveRequest, TRetrieveResponse> : 
    IRequestHandler<TRow, TRetrieveRequest, TRetrieveResponse>, IRetrieveRequestProcessor
    where TRow : class, IRow, new()
    where TRetrieveRequest : RetrieveRequest
    where TRetrieveResponse : RetrieveResponse<TRow>, new()
```

## Public Members

| name | description |
| --- | --- |
| [RetrieveRequestHandler](RetrieveRequestHandler-3/RetrieveRequestHandler.md)(…) |  |
| [Cache](RetrieveRequestHandler-3/Cache.md) { get; } |  |
| [Connection](RetrieveRequestHandler-3/Connection.md) { get; } |  |
| [Context](RetrieveRequestHandler-3/Context.md) { get; } |  |
| [Localizer](RetrieveRequestHandler-3/Localizer.md) { get; } |  |
| [Permissions](RetrieveRequestHandler-3/Permissions.md) { get; } |  |
| [Query](RetrieveRequestHandler-3/Query.md) { get; } |  |
| [StateBag](RetrieveRequestHandler-3/StateBag.md) { get; } |  |
| [User](RetrieveRequestHandler-3/User.md) { get; } |  |
| [Process](RetrieveRequestHandler-3/Process.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](RetrieveRequestHandler-3/behaviors-.md) |  |
| [Request](RetrieveRequestHandler-3/Request.md) |  |
| [Response](RetrieveRequestHandler-3/Response.md) |  |
| [Row](RetrieveRequestHandler-3/Row.md) |  |
| virtual [AllowSelectField](RetrieveRequestHandler-3/AllowSelectField.md)(…) |  |
| virtual [CreateQuery](RetrieveRequestHandler-3/CreateQuery.md)() |  |
| virtual [GetBehaviors](RetrieveRequestHandler-3/GetBehaviors.md)() |  |
| [IsIncluded](RetrieveRequestHandler-3/IsIncluded.md)(…) |  (2 methods) |
| virtual [OnAfterExecuteQuery](RetrieveRequestHandler-3/OnAfterExecuteQuery.md)() |  |
| virtual [OnBeforeExecuteQuery](RetrieveRequestHandler-3/OnBeforeExecuteQuery.md)() |  |
| virtual [OnReturn](RetrieveRequestHandler-3/OnReturn.md)() |  |
| virtual [PrepareQuery](RetrieveRequestHandler-3/PrepareQuery.md)(…) |  |
| virtual [SelectField](RetrieveRequestHandler-3/SelectField.md)(…) |  |
| virtual [SelectFields](RetrieveRequestHandler-3/SelectFields.md)(…) |  |
| virtual [ShouldSelectField](RetrieveRequestHandler-3/ShouldSelectField.md)(…) |  |
| virtual [ValidatePermissions](RetrieveRequestHandler-3/ValidatePermissions.md)() |  |
| virtual [ValidateRequest](RetrieveRequestHandler-3/ValidateRequest.md)() |  |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/RetrieveRequestHandler-3.TRow.md)
* class [TRetrieveRequest](../Serenity.Net.Services/RetrieveRequestHandler-3.TRetrieveRequest.md)
* class [TRetrieveResponse](../Serenity.Net.Services/RetrieveRequestHandler-3.TRetrieveResponse.md)
* interface [IRetrieveRequestProcessor](IRetrieveRequestProcessor.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* class [RetrieveRequest](RetrieveRequest.md)
* class [RetrieveResponse&lt;T&gt;](RetrieveResponse-1.md)
* **Source:** *[RetrieveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Retrieve/RetrieveRequestHandler.cs)*