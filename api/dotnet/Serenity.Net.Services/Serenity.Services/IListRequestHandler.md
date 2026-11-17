# IListRequestHandler interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Represents a ListRequestHandler. Is used with ListBehavior objects.

```csharp
public interface IListRequestHandler : IRequestHandler
```

## Members

| name | description |
| --- | --- |
| [Connection](IListRequestHandler/Connection.md) { get; } | Gets the current connection. |
| [Context](IListRequestHandler/Context.md) { get; } | Gets the current request context. |
| [ExecutionMode](IListRequestHandler/ExecutionMode.md) { get; } | Gets why the handler is being executed. Handlers and behaviors may check it to act differently, e.g. when the handler is only executed to build its query. The default implementation returns Normal. |
| [HandlerSettings](IListRequestHandler/HandlerSettings.md) { get; } | Gets the request handler settings, e.g. the default / maximum page size. The default implementation reads them from an [`IHasHandlerSettings`](./IHasHandlerSettings.md) capable request context, falling back to [`Default`](./RequestHandlerSettings/Default.md) (no limits). |
| [Request](IListRequestHandler/Request.md) { get; } | Gets the list request. |
| [Response](IListRequestHandler/Response.md) { get; } | Gets the list response. |
| [Row](IListRequestHandler/Row.md) { get; } | Gets the row used for querying / metadata lookup. |
| [StateBag](IListRequestHandler/StateBag.md) { get; } | Gets a state bag that can be used as storage within a request handler context. |
| [AllowSelectField](IListRequestHandler/AllowSelectField.md)(…) | Returns true if field is allowed to be selected, based on permissions and SelectLevel.Never. |
| [IgnoreEqualityFilter](IListRequestHandler/IgnoreEqualityFilter.md)(…) | Use to ignore an equality filter. |
| [ShouldSelectField](IListRequestHandler/ShouldSelectField.md)(…) | Returns true if field should be selected based on ColumnSelection flags. |

## See Also

* interface [IRequestHandler](../../Serenity.Net.Core/Serenity.Services/IRequestHandler.md)
* **Source:** *[IListRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/4e590d6757037c1f1c7364d5531af4759c4e7606/src/services/RequestHandlers/List/IListRequestHandler.cs)*