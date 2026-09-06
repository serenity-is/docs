# AsyncToSyncSaveBehaviorWrapper constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Wraps an [`ISaveBehaviorAsync`](../ISaveBehaviorAsync.md) implementation and exposes it as an [`ISaveBehaviorSync`](../ISaveBehaviorSync.md) by blocking on its async methods. This allows synchronous save request handlers to run asynchronous save behaviors.

```csharp
public AsyncToSyncSaveBehaviorWrapper(ISaveBehaviorAsync asyncBehavior)
```

| parameter | description |
| --- | --- |
| asyncBehavior | Asynchronous save behavior to wrap |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *asyncBehavior* is `null`. |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

Initializes a new instance of the class.

## See Also

* interface [ISaveBehaviorAsync](../ISaveBehaviorAsync.md)
* class [AsyncToSyncSaveBehaviorWrapper](../AsyncToSyncSaveBehaviorWrapper.md)