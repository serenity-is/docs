# IRetrieveBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A retrieve behavior that can be used as a mixin within a RetrieveRequestHandler lifecycle

```csharp
public interface IRetrieveBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterExecuteQuery](IRetrieveBehavior/OnAfterExecuteQuery.md)(…) | Called after query is sent to database |
| [OnBeforeExecuteQuery](IRetrieveBehavior/OnBeforeExecuteQuery.md)(…) | Called just before query is sent to database |
| [OnPrepareQuery](IRetrieveBehavior/OnPrepareQuery.md)(…) | Called when query to is built |
| [OnReturn](IRetrieveBehavior/OnReturn.md)(…) | Called before handler is returning the result |
| [OnValidateRequest](IRetrieveBehavior/OnValidateRequest.md)(…) | Called when retrieve request is validated |

## Remarks

A retrieve behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* **Source:** *[IRetrieveBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Retrieve/IRetrieveBehavior.cs)*