# ISaveRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a SaveRequestHandler. Is used with SaveBehavior objects.

```csharp
public interface ISaveRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](ISaveRequestHandler/Connection.md) { get; } | Current connection |
| [Context](ISaveRequestHandler/Context.md) { get; } | Current request context |
| [IsCreate](ISaveRequestHandler/IsCreate.md) { get; } | Is this an INSERT operation? |
| [IsUpdate](ISaveRequestHandler/IsUpdate.md) { get; } | Is this an UPDATE operation? |
| [Old](ISaveRequestHandler/Old.md) { get; } | Old row, if any, otherwise null |
| [Request](ISaveRequestHandler/Request.md) { get; } | Save request |
| [Response](ISaveRequestHandler/Response.md) { get; } | Save response |
| [Row](ISaveRequestHandler/Row.md) { get; } | New row |
| [StateBag](ISaveRequestHandler/StateBag.md) { get; } | A state bag that can be used as storage within a request handler context |
| [UnitOfWork](ISaveRequestHandler/UnitOfWork.md) { get; } | Current transaction |

## See Also

* interface [IRequestHandler](IRequestHandler.md)
* **Source:** *[ISaveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/ISaveRequestHandler.cs)*