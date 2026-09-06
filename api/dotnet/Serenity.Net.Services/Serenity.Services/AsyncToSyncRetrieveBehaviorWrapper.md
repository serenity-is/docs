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

## See Also

* interface [IRetrieveBehaviorSync](./IRetrieveBehaviorSync.md)
* interface [IWrappedBehavior](./IWrappedBehavior.md)
* **Source:** *[AsyncToSyncRetrieveBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/AsyncToSyncRetrieveBehaviorWrapper.cs)*