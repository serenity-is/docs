# IRetrieveBehaviorSync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A synchronous retrieve behavior that can be used as a mixin within a RetrieveRequestHandler lifecycle

```csharp
public interface IRetrieveBehaviorSync : IRetrieveBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterExecuteQuery](IRetrieveBehaviorSync/OnAfterExecuteQuery.md)(…) | Called after query is sent to database |
| [OnBeforeExecuteQuery](IRetrieveBehaviorSync/OnBeforeExecuteQuery.md)(…) | Called just before query is sent to database |
| [OnPrepareQuery](IRetrieveBehaviorSync/OnPrepareQuery.md)(…) | Called when query is built |
| [OnReturn](IRetrieveBehaviorSync/OnReturn.md)(…) | Called before handler is returning the result |
| [OnValidateRequest](IRetrieveBehaviorSync/OnValidateRequest.md)(…) | Called when retrieve request is validated |

## Remarks

A retrieve behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IRetrieveBehavior](./IRetrieveBehavior.md)
* **Source:** *[IRetrieveBehaviorSync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/Retrieve/IRetrieveBehaviorSync.cs)*