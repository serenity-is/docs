# AsyncToSyncDeleteBehaviorWrapper constructor

Wraps an [`IDeleteBehaviorAsync`](../IDeleteBehaviorAsync.md) implementation and exposes it as an [`IDeleteBehaviorSync`](../IDeleteBehaviorSync.md) by blocking on its async methods. This allows synchronous delete request handlers to run asynchronous delete behaviors.

```csharp
public AsyncToSyncDeleteBehaviorWrapper(IDeleteBehaviorAsync asyncBehavior)
```

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IDeleteBehaviorAsync](../IDeleteBehaviorAsync.md)
* class [AsyncToSyncDeleteBehaviorWrapper](../AsyncToSyncDeleteBehaviorWrapper.md)