# IUndeleteBehaviorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An asynchronous undelete behavior that can be used as a mixin within a UndeleteRequestHandlerAsync lifecycle

```csharp
public interface IUndeleteBehaviorAsync : IUndeleteBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterUndeleteAsync](IUndeleteBehaviorAsync/OnAfterUndeleteAsync.md)(…) | Called after row is undeleted in database |
| [OnAuditAsync](IUndeleteBehaviorAsync/OnAuditAsync.md)(…) | Called after row is undeleted and auditing should be performed |
| [OnBeforeUndeleteAsync](IUndeleteBehaviorAsync/OnBeforeUndeleteAsync.md)(…) | Called just before row is undeleted in database |
| [OnPrepareQueryAsync](IUndeleteBehaviorAsync/OnPrepareQueryAsync.md)(…) | Called when query to load old entity is built |
| [OnReturnAsync](IUndeleteBehaviorAsync/OnReturnAsync.md)(…) | Called before handler is returning the result |
| [OnValidateRequestAsync](IUndeleteBehaviorAsync/OnValidateRequestAsync.md)(…) | Called when undelete request is validated |

## Remarks

A undelete behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [IUndeleteBehavior](IUndeleteBehavior.md)
* **Source:** *[IUndeleteBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/Undelete/IUndeleteBehaviorAsync.cs)*