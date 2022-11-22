# IDeleteBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A delete behavior that can be used as a mixin within a DeleteRequestHandler lifecycle

```csharp
public interface IDeleteBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterDelete](IDeleteBehavior/OnAfterDelete.md)(…) | Called after row is inserted to / updated in database |
| [OnAudit](IDeleteBehavior/OnAudit.md)(…) | Called after row is inserted to / updated and auditing should be performed |
| [OnBeforeDelete](IDeleteBehavior/OnBeforeDelete.md)(…) | Called just before row is inserted to / updated in database |
| [OnPrepareQuery](IDeleteBehavior/OnPrepareQuery.md)(…) | Called when query to load old entity is built |
| [OnReturn](IDeleteBehavior/OnReturn.md)(…) | Called before handler is returning the result |
| [OnValidateRequest](IDeleteBehavior/OnValidateRequest.md)(…) | Called when delete request is validated |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* **Source:** *[IDeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/IDeleteBehavior.cs)*