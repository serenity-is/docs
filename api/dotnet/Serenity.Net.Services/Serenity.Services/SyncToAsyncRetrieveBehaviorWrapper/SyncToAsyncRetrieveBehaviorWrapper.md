# SyncToAsyncRetrieveBehaviorWrapper constructor

Wraps an [`IRetrieveBehaviorSync`](../IRetrieveBehaviorSync.md) implementation and exposes it as an [`IRetrieveBehaviorAsync`](../IRetrieveBehaviorAsync.md). This allows asynchronous retrieve request handlers to run synchronous retrieve behaviors.

```csharp
public SyncToAsyncRetrieveBehaviorWrapper(IRetrieveBehaviorSync syncBehavior)
```

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IRetrieveBehaviorSync](../IRetrieveBehaviorSync.md)
* class [SyncToAsyncRetrieveBehaviorWrapper](../SyncToAsyncRetrieveBehaviorWrapper.md)