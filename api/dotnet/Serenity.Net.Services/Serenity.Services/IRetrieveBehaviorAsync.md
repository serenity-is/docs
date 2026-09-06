# IRetrieveBehaviorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An asynchronous retrieve behavior that can be used as a mixin within a RetrieveRequestHandlerAsync lifecycle

```csharp
public interface IRetrieveBehaviorAsync : IRetrieveBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterExecuteQueryAsync](IRetrieveBehaviorAsync/OnAfterExecuteQueryAsync.md)(…) | Called after query is sent to database |
| [OnBeforeExecuteQueryAsync](IRetrieveBehaviorAsync/OnBeforeExecuteQueryAsync.md)(…) | Called just before query is sent to database |
| [OnPrepareQueryAsync](IRetrieveBehaviorAsync/OnPrepareQueryAsync.md)(…) | Called when query is built |
| [OnReturnAsync](IRetrieveBehaviorAsync/OnReturnAsync.md)(…) | Called before handler is returning the result |
| [OnValidateRequestAsync](IRetrieveBehaviorAsync/OnValidateRequestAsync.md)(…) | Called when retrieve request is validated |

## Remarks

A retrieve behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IRetrieveBehavior](IRetrieveBehavior.md)
* **Source:** *[IRetrieveBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/Retrieve/IRetrieveBehaviorAsync.cs)*