# IDeleteBehaviorSync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A synchronous delete behavior that can be used as a mixin within a DeleteRequestHandler lifecycle

```csharp
public interface IDeleteBehaviorSync : IDeleteBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterDelete](IDeleteBehaviorSync/OnAfterDelete.md)(…) | Called after row is deleted from database |
| [OnAudit](IDeleteBehaviorSync/OnAudit.md)(…) | Called after row is deleted and auditing should be performed |
| [OnBeforeDelete](IDeleteBehaviorSync/OnBeforeDelete.md)(…) | Called just before row is deleted from database |
| [OnPrepareQuery](IDeleteBehaviorSync/OnPrepareQuery.md)(…) | Called when query to load old entity is built |
| [OnReturn](IDeleteBehaviorSync/OnReturn.md)(…) | Called before handler is returning the result |
| [OnValidateRequest](IDeleteBehaviorSync/OnValidateRequest.md)(…) | Called when delete request is validated |

## Remarks

A delete behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IDeleteBehavior](IDeleteBehavior.md)
* **Source:** *[IDeleteBehaviorSync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/Delete/IDeleteBehaviorSync.cs)*