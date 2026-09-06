# ISaveBehaviorAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An asynchronous save behavior that can be used as a mixin within a SaveRequestHandlerAsync lifecycle

```csharp
public interface ISaveBehaviorAsync : ISaveBehavior
```

## Members

| name | description |
| --- | --- |
| [OnAfterSaveAsync](ISaveBehaviorAsync/OnAfterSaveAsync.md)(…) | Called after row is inserted to / updated in database |
| [OnAuditAsync](ISaveBehaviorAsync/OnAuditAsync.md)(…) | Called after row is inserted to / updated and auditing should be performed |
| [OnBeforeSaveAsync](ISaveBehaviorAsync/OnBeforeSaveAsync.md)(…) | Called just before row is inserted to / updated in database |
| [OnPrepareQueryAsync](ISaveBehaviorAsync/OnPrepareQueryAsync.md)(…) | Called when query to load old entity is built |
| [OnReturnAsync](ISaveBehaviorAsync/OnReturnAsync.md)(…) | Called before handler is returning the result |
| [OnSetInternalFieldsAsync](ISaveBehaviorAsync/OnSetInternalFieldsAsync.md)(…) | Called when internal fields in row is being set |
| [OnValidateRequestAsync](ISaveBehaviorAsync/OnValidateRequestAsync.md)(…) | Called when save request is validated |

## Remarks

A save behavior instance is always cached and reused across requests, so make sure you don't store anything in private variables, and its operation is thread-safe. If you need to pass some state between events, use handler's StateBag.

## See Also

* interface [ISaveBehavior](./ISaveBehavior.md)
* **Source:** *[ISaveBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/Save/ISaveBehaviorAsync.cs)*