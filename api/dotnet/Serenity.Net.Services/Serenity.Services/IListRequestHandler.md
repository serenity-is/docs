# IListRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a ListRequestHandler. Is used with ListBehavior objects.

```csharp
public interface IListRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](IListRequestHandler/Connection.md) { get; } | Current connection |
| [Context](IListRequestHandler/Context.md) { get; } | Current request context |
| [Request](IListRequestHandler/Request.md) { get; } | List request |
| [Response](IListRequestHandler/Response.md) { get; } | List response |
| [Row](IListRequestHandler/Row.md) { get; } | Loader row |
| [StateBag](IListRequestHandler/StateBag.md) { get; } | A state bag that can be used as storage within a request handler context |
| [AllowSelectField](IListRequestHandler/AllowSelectField.md)(…) | Returns true if field is allowed to be selected, based on permissions and SelectLevel.Never. |
| [IgnoreEqualityFilter](IListRequestHandler/IgnoreEqualityFilter.md)(…) | Use to ignore an equality filter |
| [ShouldSelectField](IListRequestHandler/ShouldSelectField.md)(…) | Returns true if field should be selected based on ColumnSelection flags. |

## See Also

* interface [IRequestHandler](IRequestHandler.md)
* **Source:** *[IListRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/IListRequestHandler.cs)*