# AsyncToSyncDeleteBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`IDeleteBehaviorAsync`](IDeleteBehaviorAsync.md) implementation and exposes it as an [`IDeleteBehaviorSync`](IDeleteBehaviorSync.md) by blocking on its async methods. This allows synchronous delete request handlers to run asynchronous delete behaviors.

```csharp
public class AsyncToSyncDeleteBehaviorWrapper : IDeleteBehaviorSync, IWrappedBehavior
```

## Public Members

| name | description |
| --- | --- |
| [AsyncToSyncDeleteBehaviorWrapper](AsyncToSyncDeleteBehaviorWrapper/AsyncToSyncDeleteBehaviorWrapper.md)(…) | Wraps an [`IDeleteBehaviorAsync`](IDeleteBehaviorAsync.md) implementation and exposes it as an [`IDeleteBehaviorSync`](IDeleteBehaviorSync.md) by blocking on its async methods. This allows synchronous delete request handlers to run asynchronous delete behaviors. |
| [WrappedBehavior](AsyncToSyncDeleteBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterDelete](AsyncToSyncDeleteBehaviorWrapper/OnAfterDelete.md)(…) |  |
| [OnAudit](AsyncToSyncDeleteBehaviorWrapper/OnAudit.md)(…) |  |
| [OnBeforeDelete](AsyncToSyncDeleteBehaviorWrapper/OnBeforeDelete.md)(…) |  |
| [OnPrepareQuery](AsyncToSyncDeleteBehaviorWrapper/OnPrepareQuery.md)(…) |  |
| [OnReturn](AsyncToSyncDeleteBehaviorWrapper/OnReturn.md)(…) |  |
| [OnValidateRequest](AsyncToSyncDeleteBehaviorWrapper/OnValidateRequest.md)(…) |  |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IDeleteBehaviorSync](IDeleteBehaviorSync.md)
* interface [IWrappedBehavior](IWrappedBehavior.md)
* **Source:** *[AsyncToSyncDeleteBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/AsyncToSyncDeleteBehaviorWrapper.cs)*