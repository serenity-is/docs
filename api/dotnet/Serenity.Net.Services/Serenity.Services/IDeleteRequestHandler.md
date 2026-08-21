# IDeleteRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a DeleteRequestHandler. Is used with DeleteBehavior objects.

```csharp
public interface IDeleteRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](IDeleteRequestHandler/Connection.md) { get; } | Gets the current connection. |
| [Context](IDeleteRequestHandler/Context.md) { get; } | Gets the current request context. |
| [Request](IDeleteRequestHandler/Request.md) { get; } | Gets the delete request. |
| [Response](IDeleteRequestHandler/Response.md) { get; } | Gets the delete response. |
| [Row](IDeleteRequestHandler/Row.md) { get; } | Gets the row being deleted. |
| [StateBag](IDeleteRequestHandler/StateBag.md) { get; } | Gets a state bag that can be used as storage within a request handler context. |
| [UnitOfWork](IDeleteRequestHandler/UnitOfWork.md) { get; } | Gets the current unit of work. |

## See Also

* interface [IRequestHandler](../Serenity.Net.Core/IRequestHandler.md)
* **Source:** *[IDeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Delete/IDeleteRequestHandler.cs)*