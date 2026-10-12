# AsyncToSyncRetrieveBehaviorWrapper constructor

Wraps an [`IRetrieveBehaviorAsync`](../IRetrieveBehaviorAsync.md) implementation and exposes it as an [`IRetrieveBehaviorSync`](../IRetrieveBehaviorSync.md) by blocking on its async methods. This allows synchronous retrieve request handlers to run asynchronous retrieve behaviors.

```csharp
public AsyncToSyncRetrieveBehaviorWrapper(IRetrieveBehaviorAsync asyncBehavior)
```

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

This is a bridging adapter that blocks on the wrapped asynchronous behavior (sync-over-async). The synchronous interface exposes no CancellationToken, so a cancellation token from an asynchronous call site cannot be observed by the wrapped behavior. Prefer invoking the asynchronous behavior directly whenever a cancellation token is available.

## See Also

* interface [IRetrieveBehaviorAsync](../IRetrieveBehaviorAsync.md)
* class [AsyncToSyncRetrieveBehaviorWrapper](../AsyncToSyncRetrieveBehaviorWrapper.md)