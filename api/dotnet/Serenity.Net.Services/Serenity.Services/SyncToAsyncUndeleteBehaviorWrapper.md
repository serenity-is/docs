# SyncToAsyncUndeleteBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`IUndeleteBehaviorSync`](IUndeleteBehaviorSync.md) implementation and exposes it as an [`IUndeleteBehaviorAsync`](IUndeleteBehaviorAsync.md). This allows asynchronous undelete request handlers to run synchronous undelete behaviors.

```csharp
public class SyncToAsyncUndeleteBehaviorWrapper : IUndeleteBehaviorAsync, IWrappedBehavior
```

## Public Members

| name | description |
| --- | --- |
| [SyncToAsyncUndeleteBehaviorWrapper](SyncToAsyncUndeleteBehaviorWrapper/SyncToAsyncUndeleteBehaviorWrapper.md)(…) | Wraps an [`IUndeleteBehaviorSync`](IUndeleteBehaviorSync.md) implementation and exposes it as an [`IUndeleteBehaviorAsync`](IUndeleteBehaviorAsync.md). This allows asynchronous undelete request handlers to run synchronous undelete behaviors. |
| [WrappedBehavior](SyncToAsyncUndeleteBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterUndeleteAsync](SyncToAsyncUndeleteBehaviorWrapper/OnAfterUndeleteAsync.md)(…) |  |
| [OnAuditAsync](SyncToAsyncUndeleteBehaviorWrapper/OnAuditAsync.md)(…) |  |
| [OnBeforeUndeleteAsync](SyncToAsyncUndeleteBehaviorWrapper/OnBeforeUndeleteAsync.md)(…) |  |
| [OnPrepareQueryAsync](SyncToAsyncUndeleteBehaviorWrapper/OnPrepareQueryAsync.md)(…) |  |
| [OnReturnAsync](SyncToAsyncUndeleteBehaviorWrapper/OnReturnAsync.md)(…) |  |
| [OnValidateRequestAsync](SyncToAsyncUndeleteBehaviorWrapper/OnValidateRequestAsync.md)(…) |  |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IUndeleteBehaviorAsync](IUndeleteBehaviorAsync.md)
* interface [IWrappedBehavior](IWrappedBehavior.md)
* **Source:** *[SyncToAsyncUndeleteBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/SyncToAsyncUndeleteBehaviorWrapper.cs)*