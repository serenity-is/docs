# SyncToAsyncRetrieveBehaviorWrapper class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps an [`IRetrieveBehaviorSync`](./IRetrieveBehaviorSync.md) implementation and exposes it as an [`IRetrieveBehaviorAsync`](./IRetrieveBehaviorAsync.md). This allows asynchronous retrieve request handlers to run synchronous retrieve behaviors.

```csharp
public class SyncToAsyncRetrieveBehaviorWrapper : IRetrieveBehaviorAsync, IWrappedBehavior
```

## Public Members

| name | description |
| --- | --- |
| [SyncToAsyncRetrieveBehaviorWrapper](SyncToAsyncRetrieveBehaviorWrapper/SyncToAsyncRetrieveBehaviorWrapper.md)(…) | Wraps an [`IRetrieveBehaviorSync`](./IRetrieveBehaviorSync.md) implementation and exposes it as an [`IRetrieveBehaviorAsync`](./IRetrieveBehaviorAsync.md). This allows asynchronous retrieve request handlers to run synchronous retrieve behaviors. |
| [WrappedBehavior](SyncToAsyncRetrieveBehaviorWrapper/WrappedBehavior.md) { get; } |  |
| [OnAfterExecuteQueryAsync](SyncToAsyncRetrieveBehaviorWrapper/OnAfterExecuteQueryAsync.md)(…) |  |
| [OnBeforeExecuteQueryAsync](SyncToAsyncRetrieveBehaviorWrapper/OnBeforeExecuteQueryAsync.md)(…) |  |
| [OnPrepareQueryAsync](SyncToAsyncRetrieveBehaviorWrapper/OnPrepareQueryAsync.md)(…) |  |
| [OnReturnAsync](SyncToAsyncRetrieveBehaviorWrapper/OnReturnAsync.md)(…) |  |
| [OnValidateRequestAsync](SyncToAsyncRetrieveBehaviorWrapper/OnValidateRequestAsync.md)(…) |  |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IRetrieveBehaviorAsync](./IRetrieveBehaviorAsync.md)
* interface [IWrappedBehavior](./IWrappedBehavior.md)
* **Source:** *[SyncToAsyncRetrieveBehaviorWrapper.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/SyncToAsyncRetrieveBehaviorWrapper.cs)*