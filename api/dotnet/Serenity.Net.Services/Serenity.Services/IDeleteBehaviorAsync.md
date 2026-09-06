# IDeleteBehaviorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An asynchronous delete behavior that can be used as a mixin within a DeleteRequestHandlerAsync lifecycle

```csharp
public interface IDeleteBehaviorAsync : IDeleteBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterDeleteAsync](IDeleteBehaviorAsync/OnAfterDeleteAsync.md)(…) | Called after row is deleted from database |
| [OnAuditAsync](IDeleteBehaviorAsync/OnAuditAsync.md)(…) | Called after row is deleted and auditing should be performed |
| [OnBeforeDeleteAsync](IDeleteBehaviorAsync/OnBeforeDeleteAsync.md)(…) | Called just before row is deleted from database |
| [OnPrepareQueryAsync](IDeleteBehaviorAsync/OnPrepareQueryAsync.md)(…) | Called when query to load old entity is built |
| [OnReturnAsync](IDeleteBehaviorAsync/OnReturnAsync.md)(…) | Called before handler is returning the result |
| [OnValidateRequestAsync](IDeleteBehaviorAsync/OnValidateRequestAsync.md)(…) | Called when delete request is validated |

## Remarks

A delete behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IDeleteBehavior](./IDeleteBehavior.md)
* **Source:** *[IDeleteBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/Delete/IDeleteBehaviorAsync.cs)*