# IUndeleteRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a UndeleteRequestHandler. Is used with UndeleteBehavior objects.

```csharp
public interface IUndeleteRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](IUndeleteRequestHandler/Connection.md) { get; } | Gets the current connection. |
| [Context](IUndeleteRequestHandler/Context.md) { get; } | Gets the current request context. |
| [Request](IUndeleteRequestHandler/Request.md) { get; } | Gets the undelete request. |
| [Response](IUndeleteRequestHandler/Response.md) { get; } | Gets the undelete response. |
| [Row](IUndeleteRequestHandler/Row.md) { get; } | Gets the row being undeleted. |
| [StateBag](IUndeleteRequestHandler/StateBag.md) { get; } | Gets a state bag that can be used as storage within a request handler context. |
| [UnitOfWork](IUndeleteRequestHandler/UnitOfWork.md) { get; } | Gets the current unit of work. |

## See Also

* interface [IRequestHandler](../../Serenity.Net.Core/Serenity.Services/IRequestHandler.md)
* **Source:** *[IUndeleteRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Undelete/IUndeleteRequestHandler.cs)*