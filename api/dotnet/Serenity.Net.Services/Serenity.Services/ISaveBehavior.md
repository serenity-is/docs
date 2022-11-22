# ISaveBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A save behavior that can be used as a mixin within a SaveRequestHandler lifecycle

```csharp
public interface ISaveBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterSave](ISaveBehavior/OnAfterSave.md)(…) | Called after row is inserted to / updated in database |
| [OnAudit](ISaveBehavior/OnAudit.md)(…) | Called after row is inserted to / updated and auditing should be performed |
| [OnBeforeSave](ISaveBehavior/OnBeforeSave.md)(…) | Called just before row is inserted to / updated in database |
| [OnPrepareQuery](ISaveBehavior/OnPrepareQuery.md)(…) | Called when query to load old entity is built |
| [OnReturn](ISaveBehavior/OnReturn.md)(…) | Called before handler is returning the result |
| [OnSetInternalFields](ISaveBehavior/OnSetInternalFields.md)(…) | Called when internal fields in row is being set |
| [OnValidateRequest](ISaveBehavior/OnValidateRequest.md)(…) | Called when save request is validated |

## Remarks

A save behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* **Source:** *[ISaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/ISaveBehavior.cs)*