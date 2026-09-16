# SyncToAsyncSaveBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`ISaveBehaviorSync`](./ISaveBehaviorSync.md) implementation and exposes it as an [`ISaveBehaviorAsync`](./ISaveBehaviorAsync.md). This allows asynchronous save request handlers to run synchronous save behaviors.

```csharp
public class SyncToAsyncSaveBehaviorWrapper : ISaveBehaviorAsync, IWrappedBehavior
```

| parameter | description |
| --- | --- |
| syncBehavior | Synchronous save behavior to wrap |

## Public Members

| name | description |
| --- | --- |
| [SyncToAsyncSaveBehaviorWrapper](SyncToAsyncSaveBehaviorWrapper/SyncToAsyncSaveBehaviorWrapper.md)(…) | Wraps an [`ISaveBehaviorSync`](./ISaveBehaviorSync.md) implementation and exposes it as an [`ISaveBehaviorAsync`](./ISaveBehaviorAsync.md). This allows asynchronous save request handlers to run synchronous save behaviors. |
| [WrappedBehavior](SyncToAsyncSaveBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterSaveAsync](SyncToAsyncSaveBehaviorWrapper/OnAfterSaveAsync.md)(…) |  |
| [OnAuditAsync](SyncToAsyncSaveBehaviorWrapper/OnAuditAsync.md)(…) |  |
| [OnBeforeSaveAsync](SyncToAsyncSaveBehaviorWrapper/OnBeforeSaveAsync.md)(…) |  |
| [OnPrepareQueryAsync](SyncToAsyncSaveBehaviorWrapper/OnPrepareQueryAsync.md)(…) |  |
| [OnReturnAsync](SyncToAsyncSaveBehaviorWrapper/OnReturnAsync.md)(…) |  |
| [OnSetInternalFieldsAsync](SyncToAsyncSaveBehaviorWrapper/OnSetInternalFieldsAsync.md)(…) |  |
| [OnValidateRequestAsync](SyncToAsyncSaveBehaviorWrapper/OnValidateRequestAsync.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *syncBehavior* is `null`. |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

Initializes a new instance of the class.

## See Also

* interface [ISaveBehaviorAsync](./ISaveBehaviorAsync.md)
* interface [IWrappedBehavior](./IWrappedBehavior.md)
* **Source:** *[SyncToAsyncSaveBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/0ecdd6666300147eb7b98189e3ebb71954692e8c/src/services/RequestHandlers/Save/SyncToAsyncSaveBehaviorWrapper.cs)*