# IListBehaviorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An asynchronous list behavior that can be used as a mixin within a ListRequestHandlerAsync lifecycle

```csharp
public interface IListBehaviorAsync : IListBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterExecuteQueryAsync](IListBehaviorAsync/OnAfterExecuteQueryAsync.md)(…) | Called after query is sent to database |
| [OnApplyFiltersAsync](IListBehaviorAsync/OnApplyFiltersAsync.md)(…) | Called when filters are applied to query |
| [OnBeforeExecuteQueryAsync](IListBehaviorAsync/OnBeforeExecuteQueryAsync.md)(…) | Called just before query is sent to database |
| [OnPrepareQueryAsync](IListBehaviorAsync/OnPrepareQueryAsync.md)(…) | Called when query is built |
| [OnReturnAsync](IListBehaviorAsync/OnReturnAsync.md)(…) | Called before handler is returning the result |
| [OnValidateRequestAsync](IListBehaviorAsync/OnValidateRequestAsync.md)(…) | Called when list request is validated |

## Remarks

A list behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IListBehavior](./IListBehavior.md)
* **Source:** *[IListBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/List/IListBehaviorAsync.cs)*