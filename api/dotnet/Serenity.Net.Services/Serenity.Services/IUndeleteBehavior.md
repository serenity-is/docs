# IUndeleteBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A undelete behavior that can be used as a mixin within a UndeleteRequestHandler lifecycle

```csharp
public interface IUndeleteBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterUndelete](IUndeleteBehavior/OnAfterUndelete.md)(…) | Called after row is undeleted in database |
| [OnAudit](IUndeleteBehavior/OnAudit.md)(…) | Called after row is undeleted and auditing should be performed |
| [OnBeforeUndelete](IUndeleteBehavior/OnBeforeUndelete.md)(…) | Called just before row is undeleted in database |
| [OnPrepareQuery](IUndeleteBehavior/OnPrepareQuery.md)(…) | Called when query to load old entity is built |
| [OnReturn](IUndeleteBehavior/OnReturn.md)(…) | Called before handler is returning the result |
| [OnValidateRequest](IUndeleteBehavior/OnValidateRequest.md)(…) | Called when undelete request is validated |

## Remarks

A behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* **Source:** *[IUndeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Undelete/IUndeleteBehavior.cs)*