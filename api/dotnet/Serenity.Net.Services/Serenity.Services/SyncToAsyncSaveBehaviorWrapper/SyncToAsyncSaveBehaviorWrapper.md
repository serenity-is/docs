# SyncToAsyncSaveBehaviorWrapper constructor

Wraps an [`ISaveBehaviorSync`](../ISaveBehaviorSync.md) implementation and exposes it as an [`ISaveBehaviorAsync`](../ISaveBehaviorAsync.md). This allows asynchronous save request handlers to run synchronous save behaviors.

```csharp
public SyncToAsyncSaveBehaviorWrapper(ISaveBehaviorSync syncBehavior)
```

| parameter | description |
| --- | --- |
| syncBehavior | Synchronous save behavior to wrap |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *syncBehavior* is `null`. |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

Initializes a new instance of the class.

## See Also

* interface [ISaveBehaviorSync](../ISaveBehaviorSync.md)
* class [SyncToAsyncSaveBehaviorWrapper](../SyncToAsyncSaveBehaviorWrapper.md)