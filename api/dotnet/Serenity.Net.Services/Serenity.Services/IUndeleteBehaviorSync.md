# IUndeleteBehaviorSync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A synchronous undelete behavior that can be used as a mixin within a UndeleteRequestHandler lifecycle

```csharp
public interface IUndeleteBehaviorSync : IUndeleteBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterUndelete](IUndeleteBehaviorSync/OnAfterUndelete.md)(…) | Called after row is undeleted in database |
| [OnAudit](IUndeleteBehaviorSync/OnAudit.md)(…) | Called after row is undeleted and auditing should be performed |
| [OnBeforeUndelete](IUndeleteBehaviorSync/OnBeforeUndelete.md)(…) | Called just before row is undeleted in database |
| [OnPrepareQuery](IUndeleteBehaviorSync/OnPrepareQuery.md)(…) | Called when query to load old entity is built |
| [OnReturn](IUndeleteBehaviorSync/OnReturn.md)(…) | Called before handler is returning the result |
| [OnValidateRequest](IUndeleteBehaviorSync/OnValidateRequest.md)(…) | Called when undelete request is validated |

## Remarks

A undelete behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IUndeleteBehavior](IUndeleteBehavior.md)
* **Source:** *[IUndeleteBehaviorSync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/Undelete/IUndeleteBehaviorSync.cs)*