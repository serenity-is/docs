# IUndeleteRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a UndeleteRequestHandler. Is used with UndeleteBehavior objects.

```csharp
public interface IUndeleteRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](IUndeleteRequestHandler/Connection.md) { get; } | Current connection |
| [Context](IUndeleteRequestHandler/Context.md) { get; } | Current request context |
| [Request](IUndeleteRequestHandler/Request.md) { get; } | Undelete request |
| [Response](IUndeleteRequestHandler/Response.md) { get; } | Delete response |
| [Row](IUndeleteRequestHandler/Row.md) { get; } | New row |
| [StateBag](IUndeleteRequestHandler/StateBag.md) { get; } | A state bag that can be used as storage within a request handler context |
| [UnitOfWork](IUndeleteRequestHandler/UnitOfWork.md) { get; } | Current transaction |

## See Also

* interface [IRequestHandler](IRequestHandler.md)
* **Source:** *[IUndeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Undelete/IUndeleteRequestHandler.cs)*