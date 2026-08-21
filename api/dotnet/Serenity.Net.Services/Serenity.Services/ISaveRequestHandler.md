# ISaveRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a SaveRequestHandler. Is used with SaveBehavior objects.

```csharp
public interface ISaveRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](ISaveRequestHandler/Connection.md) { get; } | Gets the current connection. |
| [Context](ISaveRequestHandler/Context.md) { get; } | Gets the current request context. |
| [IsCreate](ISaveRequestHandler/IsCreate.md) { get; } | Gets a value indicating whether this is an INSERT operation. |
| [IsUpdate](ISaveRequestHandler/IsUpdate.md) { get; } | Gets a value indicating whether this is an UPDATE operation. |
| [Old](ISaveRequestHandler/Old.md) { get; } | Gets the old row, if any, otherwise `null`. |
| [Request](ISaveRequestHandler/Request.md) { get; } | Gets the save request. |
| [Response](ISaveRequestHandler/Response.md) { get; } | Gets the save response. |
| [Row](ISaveRequestHandler/Row.md) { get; } | Gets the new row. |
| [StateBag](ISaveRequestHandler/StateBag.md) { get; } | Gets a state bag that can be used as storage within a request handler context. |
| [UnitOfWork](ISaveRequestHandler/UnitOfWork.md) { get; } | Gets the current unit of work. |

## See Also

* interface [IRequestHandler](../Serenity.Net.Core/IRequestHandler.md)
* **Source:** *[ISaveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Save/ISaveRequestHandler.cs)*