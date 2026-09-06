# AsyncToSyncSaveBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`ISaveBehaviorAsync`](ISaveBehaviorAsync.md) implementation and exposes it as an [`ISaveBehaviorSync`](ISaveBehaviorSync.md) by blocking on its async methods. This allows synchronous save request handlers to run asynchronous save behaviors.

```csharp
public class AsyncToSyncSaveBehaviorWrapper : ISaveBehaviorSync, IWrappedBehavior
```

| parameter | description |
| --- | --- |
| asyncBehavior | Asynchronous save behavior to wrap |

## Public Members

| name | description |
| --- | --- |
| [AsyncToSyncSaveBehaviorWrapper](AsyncToSyncSaveBehaviorWrapper/AsyncToSyncSaveBehaviorWrapper.md)(…) | Wraps an [`ISaveBehaviorAsync`](ISaveBehaviorAsync.md) implementation and exposes it as an [`ISaveBehaviorSync`](ISaveBehaviorSync.md) by blocking on its async methods. This allows synchronous save request handlers to run asynchronous save behaviors. |
| [WrappedBehavior](AsyncToSyncSaveBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterSave](AsyncToSyncSaveBehaviorWrapper/OnAfterSave.md)(…) |  |
| [OnAudit](AsyncToSyncSaveBehaviorWrapper/OnAudit.md)(…) |  |
| [OnBeforeSave](AsyncToSyncSaveBehaviorWrapper/OnBeforeSave.md)(…) |  |
| [OnPrepareQuery](AsyncToSyncSaveBehaviorWrapper/OnPrepareQuery.md)(…) |  |
| [OnReturn](AsyncToSyncSaveBehaviorWrapper/OnReturn.md)(…) |  |
| [OnSetInternalFields](AsyncToSyncSaveBehaviorWrapper/OnSetInternalFields.md)(…) |  |
| [OnValidateRequest](AsyncToSyncSaveBehaviorWrapper/OnValidateRequest.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *asyncBehavior* is `null`. |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

Initializes a new instance of the class.

## See Also

* interface [ISaveBehaviorSync](ISaveBehaviorSync.md)
* interface [IWrappedBehavior](IWrappedBehavior.md)
* **Source:** *[AsyncToSyncSaveBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Save/AsyncToSyncSaveBehaviorWrapper.cs)*