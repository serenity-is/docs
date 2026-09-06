# AsyncToSyncListBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`IListBehaviorAsync`](./IListBehaviorAsync.md) implementation and exposes it as an [`IListBehaviorSync`](./IListBehaviorSync.md) by blocking on its async methods. This allows synchronous list request handlers to run asynchronous list behaviors.

```csharp
public class AsyncToSyncListBehaviorWrapper : IListBehaviorSync, IWrappedBehavior
```

## Public Members

| name | description |
| --- | --- |
| [AsyncToSyncListBehaviorWrapper](AsyncToSyncListBehaviorWrapper/AsyncToSyncListBehaviorWrapper.md)(…) | Wraps an [`IListBehaviorAsync`](./IListBehaviorAsync.md) implementation and exposes it as an [`IListBehaviorSync`](./IListBehaviorSync.md) by blocking on its async methods. This allows synchronous list request handlers to run asynchronous list behaviors. |
| [WrappedBehavior](AsyncToSyncListBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterExecuteQuery](AsyncToSyncListBehaviorWrapper/OnAfterExecuteQuery.md)(…) |  |
| [OnApplyFilters](AsyncToSyncListBehaviorWrapper/OnApplyFilters.md)(…) |  |
| [OnBeforeExecuteQuery](AsyncToSyncListBehaviorWrapper/OnBeforeExecuteQuery.md)(…) |  |
| [OnPrepareQuery](AsyncToSyncListBehaviorWrapper/OnPrepareQuery.md)(…) |  |
| [OnReturn](AsyncToSyncListBehaviorWrapper/OnReturn.md)(…) |  |
| [OnValidateRequest](AsyncToSyncListBehaviorWrapper/OnValidateRequest.md)(…) |  |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IListBehaviorSync](./IListBehaviorSync.md)
* interface [IWrappedBehavior](./IWrappedBehavior.md)
* **Source:** *[AsyncToSyncListBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/6b0ee5bf7cf3317b3c89e88bd6a74f4e510d83c6/src/services/RequestHandlers/List/AsyncToSyncListBehaviorWrapper.cs)*