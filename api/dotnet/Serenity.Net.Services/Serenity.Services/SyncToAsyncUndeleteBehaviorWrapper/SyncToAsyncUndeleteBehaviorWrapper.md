# SyncToAsyncUndeleteBehaviorWrapper constructor

Wraps an [`IUndeleteBehaviorSync`](../IUndeleteBehaviorSync.md) implementation and exposes it as an [`IUndeleteBehaviorAsync`](../IUndeleteBehaviorAsync.md). This allows asynchronous undelete request handlers to run synchronous undelete behaviors.

```csharp
public SyncToAsyncUndeleteBehaviorWrapper(IUndeleteBehaviorSync syncBehavior)
```

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IUndeleteBehaviorSync](../IUndeleteBehaviorSync.md)
* class [SyncToAsyncUndeleteBehaviorWrapper](../SyncToAsyncUndeleteBehaviorWrapper.md)