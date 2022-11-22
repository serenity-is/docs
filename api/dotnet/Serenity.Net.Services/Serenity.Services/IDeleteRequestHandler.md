# IDeleteRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a DeleteRequestHandler. Is used with DeleteBehavior objects.

```csharp
public interface IDeleteRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](IDeleteRequestHandler/Connection.md) { get; } | Current connection |
| [Context](IDeleteRequestHandler/Context.md) { get; } | Current request context |
| [Request](IDeleteRequestHandler/Request.md) { get; } | Delete request |
| [Response](IDeleteRequestHandler/Response.md) { get; } | Delete response |
| [Row](IDeleteRequestHandler/Row.md) { get; } | New row |
| [StateBag](IDeleteRequestHandler/StateBag.md) { get; } | A state bag that can be used as storage within a request handler context |
| [UnitOfWork](IDeleteRequestHandler/UnitOfWork.md) { get; } | Current transaction |

## See Also

* interface [IRequestHandler](IRequestHandler.md)
* **Source:** *[IDeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/IDeleteRequestHandler.cs)*