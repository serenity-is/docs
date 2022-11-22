# IRetrieveRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a RetrieveRequestHandler. Is used with RetrieveBehavior objects.

```csharp
public interface IRetrieveRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](IRetrieveRequestHandler/Connection.md) { get; } | Current connection |
| [Context](IRetrieveRequestHandler/Context.md) { get; } | Current request context |
| [Request](IRetrieveRequestHandler/Request.md) { get; } | Retrieve request |
| [Response](IRetrieveRequestHandler/Response.md) { get; } | Retrieve response |
| [Row](IRetrieveRequestHandler/Row.md) { get; } | Loader row |
| [StateBag](IRetrieveRequestHandler/StateBag.md) { get; } | A state bag that can be used as storage within a request handler context |
| [AllowSelectField](IRetrieveRequestHandler/AllowSelectField.md)(…) | Returns true if field is allowed to be selected based on permissions and SelectLevel.Never flag. |
| [ShouldSelectField](IRetrieveRequestHandler/ShouldSelectField.md)(…) | Returns true if field should be selected based on ColumnSelection flags. |

## See Also

* interface [IRequestHandler](IRequestHandler.md)
* **Source:** *[IRetrieveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Retrieve/IRetrieveRequestHandler.cs)*