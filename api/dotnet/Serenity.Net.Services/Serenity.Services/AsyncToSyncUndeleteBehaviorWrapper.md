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

## See Also

* interface [IUndeleteBehaviorSync](./IUndeleteBehaviorSync.md)
* interface [IWrappedBehavior](./IWrappedBehavior.md)
* **Source:** *[AsyncToSyncUndeleteBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/AsyncToSyncUndeleteBehaviorWrapper.cs)*