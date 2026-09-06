# SyncToAsyncDeleteBehaviorWrapper constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Wraps an [`IDeleteBehaviorSync`](../IDeleteBehaviorSync.md) implementation and exposes it as an [`IDeleteBehaviorAsync`](../IDeleteBehaviorAsync.md). This allows asynchronous delete request handlers to run synchronous delete behaviors.

```csharp
public SyncToAsyncDeleteBehaviorWrapper(IDeleteBehaviorSync syncBehavior)
```

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IDeleteBehaviorSync](../IDeleteBehaviorSync.md)
* class [SyncToAsyncDeleteBehaviorWrapper](../SyncToAsyncDeleteBehaviorWrapper.md)