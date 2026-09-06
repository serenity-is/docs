# SyncToAsyncListBehaviorWrapper constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Wraps an [`IListBehaviorSync`](../IListBehaviorSync.md) implementation and exposes it as an [`IListBehaviorAsync`](../IListBehaviorAsync.md). This allows asynchronous list request handlers to run synchronous list behaviors.

```csharp
public SyncToAsyncListBehaviorWrapper(IListBehaviorSync syncBehavior)
```

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IListBehaviorSync](../IListBehaviorSync.md)
* class [SyncToAsyncListBehaviorWrapper](../SyncToAsyncListBehaviorWrapper.md)