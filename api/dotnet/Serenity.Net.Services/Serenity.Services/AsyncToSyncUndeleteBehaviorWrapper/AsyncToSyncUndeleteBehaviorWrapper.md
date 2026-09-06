# AsyncToSyncUndeleteBehaviorWrapper constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Wraps an [`IUndeleteBehaviorAsync`](../IUndeleteBehaviorAsync.md) implementation and exposes it as an [`IUndeleteBehaviorSync`](../IUndeleteBehaviorSync.md) by blocking on its async methods. This allows synchronous undelete request handlers to run asynchronous undelete behaviors.

```csharp
public AsyncToSyncUndeleteBehaviorWrapper(IUndeleteBehaviorAsync asyncBehavior)
```

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IUndeleteBehaviorAsync](../IUndeleteBehaviorAsync.md)
* class [AsyncToSyncUndeleteBehaviorWrapper](../AsyncToSyncUndeleteBehaviorWrapper.md)