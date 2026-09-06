# IListBehaviorSync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A synchronous list behavior that can be used as a mixin within a ListRequestHandler lifecycle

```csharp
public interface IListBehaviorSync : IListBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterExecuteQuery](IListBehaviorSync/OnAfterExecuteQuery.md)(…) | Called after query is sent to database |
| [OnApplyFilters](IListBehaviorSync/OnApplyFilters.md)(…) | Called when filters are applied to query |
| [OnBeforeExecuteQuery](IListBehaviorSync/OnBeforeExecuteQuery.md)(…) | Called just before query is sent to database |
| [OnPrepareQuery](IListBehaviorSync/OnPrepareQuery.md)(…) | Called when query is built |
| [OnReturn](IListBehaviorSync/OnReturn.md)(…) | Called before handler is returning the result |
| [OnValidateRequest](IListBehaviorSync/OnValidateRequest.md)(…) | Called when list request is validated |

## Remarks

A list behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IListBehavior](./IListBehavior.md)
* **Source:** *[IListBehaviorSync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/List/IListBehaviorSync.cs)*