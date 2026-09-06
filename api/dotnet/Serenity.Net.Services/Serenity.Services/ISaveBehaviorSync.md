# ISaveBehaviorSync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A synchronous save behavior that can be used as a mixin within a SaveRequestHandler lifecycle

```csharp
public interface ISaveBehaviorSync : ISaveBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterSave](ISaveBehaviorSync/OnAfterSave.md)(…) | Called after row is inserted to / updated in database |
| [OnAudit](ISaveBehaviorSync/OnAudit.md)(…) | Called after row is inserted to / updated and auditing should be performed |
| [OnBeforeSave](ISaveBehaviorSync/OnBeforeSave.md)(…) | Called just before row is inserted to / updated in database |
| [OnPrepareQuery](ISaveBehaviorSync/OnPrepareQuery.md)(…) | Called when query to load old entity is built |
| [OnReturn](ISaveBehaviorSync/OnReturn.md)(…) | Called before handler is returning the result |
| [OnSetInternalFields](ISaveBehaviorSync/OnSetInternalFields.md)(…) | Called when internal fields in row is being set |
| [OnValidateRequest](ISaveBehaviorSync/OnValidateRequest.md)(…) | Called when save request is validated |

## Remarks

A save behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [ISaveBehavior](ISaveBehavior.md)
* **Source:** *[ISaveBehaviorSync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/Save/ISaveBehaviorSync.cs)*