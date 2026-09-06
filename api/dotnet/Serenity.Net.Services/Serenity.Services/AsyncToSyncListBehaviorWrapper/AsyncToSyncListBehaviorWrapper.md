# AsyncToSyncListBehaviorWrapper constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Wraps an [`IListBehaviorAsync`](../IListBehaviorAsync.md) implementation and exposes it as an [`IListBehaviorSync`](../IListBehaviorSync.md) by blocking on its async methods. This allows synchronous list request handlers to run asynchronous list behaviors.

```csharp
public AsyncToSyncListBehaviorWrapper(IListBehaviorAsync asyncBehavior)
```

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IListBehaviorAsync](../IListBehaviorAsync.md)
* class [AsyncToSyncListBehaviorWrapper](../AsyncToSyncListBehaviorWrapper.md)