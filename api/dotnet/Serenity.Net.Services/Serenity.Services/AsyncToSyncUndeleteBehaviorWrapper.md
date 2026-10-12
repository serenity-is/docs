# AsyncToSyncUndeleteBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`IUndeleteBehaviorAsync`](./IUndeleteBehaviorAsync.md) implementation and exposes it as an [`IUndeleteBehaviorSync`](./IUndeleteBehaviorSync.md) by blocking on its async methods. This allows synchronous undelete request handlers to run asynchronous undelete behaviors.

```csharp
public class AsyncToSyncUndeleteBehaviorWrapper : IUndeleteBehaviorSync, IWrappedBehavior
```

## Public Members

| name | description |
| --- | --- |
| [AsyncToSyncUndeleteBehaviorWrapper](AsyncToSyncUndeleteBehaviorWrapper/AsyncToSyncUndeleteBehaviorWrapper.md)(…) | Wraps an [`IUndeleteBehaviorAsync`](./IUndeleteBehaviorAsync.md) implementation and exposes it as an [`IUndeleteBehaviorSync`](./IUndeleteBehaviorSync.md) by blocking on its async methods. This allows synchronous undelete request handlers to run asynchronous undelete behaviors. |
| [WrappedBehavior](AsyncToSyncUndeleteBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterUndelete](AsyncToSyncUndeleteBehaviorWrapper/OnAfterUndelete.md)(…) |  |
| [OnAudit](AsyncToSyncUndeleteBehaviorWrapper/OnAudit.md)(…) |  |
| [OnBeforeUndelete](AsyncToSyncUndeleteBehaviorWrapper/OnBeforeUndelete.md)(…) |  |
| [OnPrepareQuery](AsyncToSyncUndeleteBehaviorWrapper/OnPrepareQuery.md)(…) |  |
| [OnReturn](AsyncToSyncUndeleteBehaviorWrapper/OnReturn.md)(…) |  |
| [OnValidateRequest](AsyncToSyncUndeleteBehaviorWrapper/OnValidateRequest.md)(…) |  |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

This is a bridging adapter that blocks on the wrapped asynchronous behavior (sync-over-async). The synchronous interface exposes no CancellationToken, so a cancellation token from an asynchronous call site cannot be observed by the wrapped behavior. Prefer invoking the asynchronous behavior directly whenever a cancellation token is available.

## See Also

* interface [IUndeleteBehaviorSync](./IUndeleteBehaviorSync.md)
* interface [IWrappedBehavior](./IWrappedBehavior.md)
* **Source:** *[AsyncToSyncUndeleteBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/44900868017cc7651dfdf50e177002884d4c35e1/src/services/RequestHandlers/Undelete/AsyncToSyncUndeleteBehaviorWrapper.cs)*