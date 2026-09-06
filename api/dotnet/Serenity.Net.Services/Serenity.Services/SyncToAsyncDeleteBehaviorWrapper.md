# SyncToAsyncDeleteBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`IDeleteBehaviorSync`](./IDeleteBehaviorSync.md) implementation and exposes it as an [`IDeleteBehaviorAsync`](./IDeleteBehaviorAsync.md). This allows asynchronous delete request handlers to run synchronous delete behaviors.

```csharp
public class SyncToAsyncDeleteBehaviorWrapper : IDeleteBehaviorAsync, IWrappedBehavior
```

## Public Members

| name | description |
| --- | --- |
| [SyncToAsyncDeleteBehaviorWrapper](SyncToAsyncDeleteBehaviorWrapper/SyncToAsyncDeleteBehaviorWrapper.md)(…) | Wraps an [`IDeleteBehaviorSync`](./IDeleteBehaviorSync.md) implementation and exposes it as an [`IDeleteBehaviorAsync`](./IDeleteBehaviorAsync.md). This allows asynchronous delete request handlers to run synchronous delete behaviors. |
| [WrappedBehavior](SyncToAsyncDeleteBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterDeleteAsync](SyncToAsyncDeleteBehaviorWrapper/OnAfterDeleteAsync.md)(…) |  |
| [OnAuditAsync](SyncToAsyncDeleteBehaviorWrapper/OnAuditAsync.md)(…) |  |
| [OnBeforeDeleteAsync](SyncToAsyncDeleteBehaviorWrapper/OnBeforeDeleteAsync.md)(…) |  |
| [OnPrepareQueryAsync](SyncToAsyncDeleteBehaviorWrapper/OnPrepareQueryAsync.md)(…) |  |
| [OnReturnAsync](SyncToAsyncDeleteBehaviorWrapper/OnReturnAsync.md)(…) |  |
| [OnValidateRequestAsync](SyncToAsyncDeleteBehaviorWrapper/OnValidateRequestAsync.md)(…) |  |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IDeleteBehaviorAsync](./IDeleteBehaviorAsync.md)
* interface [IWrappedBehavior](./IWrappedBehavior.md)
* **Source:** *[SyncToAsyncDeleteBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/SyncToAsyncDeleteBehaviorWrapper.cs)*