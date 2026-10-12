# AsyncToSyncRetrieveBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`IRetrieveBehaviorAsync`](./IRetrieveBehaviorAsync.md) implementation and exposes it as an [`IRetrieveBehaviorSync`](./IRetrieveBehaviorSync.md) by blocking on its async methods. This allows synchronous retrieve request handlers to run asynchronous retrieve behaviors.

```csharp
public class AsyncToSyncRetrieveBehaviorWrapper : IRetrieveBehaviorSync, IWrappedBehavior
```

## Public Members

| name | description |
| --- | --- |
| [AsyncToSyncRetrieveBehaviorWrapper](AsyncToSyncRetrieveBehaviorWrapper/AsyncToSyncRetrieveBehaviorWrapper.md)(…) | Wraps an [`IRetrieveBehaviorAsync`](./IRetrieveBehaviorAsync.md) implementation and exposes it as an [`IRetrieveBehaviorSync`](./IRetrieveBehaviorSync.md) by blocking on its async methods. This allows synchronous retrieve request handlers to run asynchronous retrieve behaviors. |
| [WrappedBehavior](AsyncToSyncRetrieveBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterExecuteQuery](AsyncToSyncRetrieveBehaviorWrapper/OnAfterExecuteQuery.md)(…) |  |
| [OnBeforeExecuteQuery](AsyncToSyncRetrieveBehaviorWrapper/OnBeforeExecuteQuery.md)(…) |  |
| [OnPrepareQuery](AsyncToSyncRetrieveBehaviorWrapper/OnPrepareQuery.md)(…) |  |
| [OnReturn](AsyncToSyncRetrieveBehaviorWrapper/OnReturn.md)(…) |  |
| [OnValidateRequest](AsyncToSyncRetrieveBehaviorWrapper/OnValidateRequest.md)(…) |  |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

This is a bridging adapter that blocks on the wrapped asynchronous behavior (sync-over-async). The synchronous interface exposes no CancellationToken, so a cancellation token from an asynchronous call site cannot be observed by the wrapped behavior. Prefer invoking the asynchronous behavior directly whenever a cancellation token is available.

## See Also

* interface [IRetrieveBehaviorSync](./IRetrieveBehaviorSync.md)
* interface [IWrappedBehavior](./IWrappedBehavior.md)
* **Source:** *[AsyncToSyncRetrieveBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/44900868017cc7651dfdf50e177002884d4c35e1/src/services/RequestHandlers/Retrieve/AsyncToSyncRetrieveBehaviorWrapper.cs)*