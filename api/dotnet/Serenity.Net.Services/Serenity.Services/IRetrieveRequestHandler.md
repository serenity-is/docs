# IRetrieveRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a RetrieveRequestHandler. Is used with RetrieveBehavior objects.

```csharp
public interface IRetrieveRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](IRetrieveRequestHandler/Connection.md) { get; } | Gets the current connection. |
| [Context](IRetrieveRequestHandler/Context.md) { get; } | Gets the current request context. |
| [Request](IRetrieveRequestHandler/Request.md) { get; } | Gets the retrieve request. |
| [Response](IRetrieveRequestHandler/Response.md) { get; } | Gets the retrieve response. |
| [Row](IRetrieveRequestHandler/Row.md) { get; } | Gets the row used for querying / metadata lookup. |
| [StateBag](IRetrieveRequestHandler/StateBag.md) { get; } | Gets a state bag that can be used as storage within a request handler context. |
| [AllowSelectField](IRetrieveRequestHandler/AllowSelectField.md)(…) | Returns true if field is allowed to be selected based on permissions and SelectLevel.Never flag. |
| [ShouldSelectField](IRetrieveRequestHandler/ShouldSelectField.md)(…) | Returns true if field should be selected based on ColumnSelection flags. |

## See Also

* interface [IRequestHandler](../Serenity.Net.Core/IRequestHandler.md)
* **Source:** *[IRetrieveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Retrieve/IRetrieveRequestHandler.cs)*