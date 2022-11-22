# IListBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A list behavior that can be used as a mixin within a ListRequestHandler lifecycle

```csharp
public interface IListBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterExecuteQuery](IListBehavior/OnAfterExecuteQuery.md)(…) | Called after query is sent to database |
| [OnApplyFilters](IListBehavior/OnApplyFilters.md)(…) | Called when filters are applied to query |
| [OnBeforeExecuteQuery](IListBehavior/OnBeforeExecuteQuery.md)(…) | Called just before query is sent to database |
| [OnPrepareQuery](IListBehavior/OnPrepareQuery.md)(…) | Called when query to is built |
| [OnReturn](IListBehavior/OnReturn.md)(…) | Called before handler is returning the result |
| [OnValidateRequest](IListBehavior/OnValidateRequest.md)(…) | Called when list request is validated |

## Remarks

A list behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* **Source:** *[IListBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/List/IListBehavior.cs)*