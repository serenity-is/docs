# SyncToAsyncListBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`IListBehaviorSync`](IListBehaviorSync.md) implementation and exposes it as an [`IListBehaviorAsync`](IListBehaviorAsync.md). This allows asynchronous list request handlers to run synchronous list behaviors.

```csharp
public class SyncToAsyncListBehaviorWrapper : IListBehaviorAsync, IWrappedBehavior
```

## Public Members

| name | description |
| --- | --- |
| [SyncToAsyncListBehaviorWrapper](SyncToAsyncListBehaviorWrapper/SyncToAsyncListBehaviorWrapper.md)(…) | Wraps an [`IListBehaviorSync`](IListBehaviorSync.md) implementation and exposes it as an [`IListBehaviorAsync`](IListBehaviorAsync.md). This allows asynchronous list request handlers to run synchronous list behaviors. |
| [WrappedBehavior](SyncToAsyncListBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterExecuteQueryAsync](SyncToAsyncListBehaviorWrapper/OnAfterExecuteQueryAsync.md)(…) |  |
| [OnApplyFiltersAsync](SyncToAsyncListBehaviorWrapper/OnApplyFiltersAsync.md)(…) |  |
| [OnBeforeExecuteQueryAsync](SyncToAsyncListBehaviorWrapper/OnBeforeExecuteQueryAsync.md)(…) |  |
| [OnPrepareQueryAsync](SyncToAsyncListBehaviorWrapper/OnPrepareQueryAsync.md)(…) |  |
| [OnReturnAsync](SyncToAsyncListBehaviorWrapper/OnReturnAsync.md)(…) |  |
| [OnValidateRequestAsync](SyncToAsyncListBehaviorWrapper/OnValidateRequestAsync.md)(…) |  |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IListBehaviorAsync](IListBehaviorAsync.md)
* interface [IWrappedBehavior](IWrappedBehavior.md)
* **Source:** *[SyncToAsyncListBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/6b0ee5bf7cf3317b3c89e88bd6a74f4e510d83c6/src/services/RequestHandlers/List/SyncToAsyncListBehaviorWrapper.cs)*