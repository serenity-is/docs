# CaptureLogBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Capture log behavior

```csharp
public class CaptureLogBehavior : BaseSaveDeleteBehaviorAsync, IDeleteBehaviorSync, 
    IImplicitBehavior, ISaveBehaviorSync, IUndeleteBehaviorAsync, IUndeleteBehaviorSync
```

## Public Members

| name | description |
| --- | --- |
| [CaptureLogBehavior](CaptureLogBehavior/CaptureLogBehavior.md)() | The default constructor. |
| [ActivateFor](CaptureLogBehavior/ActivateFor.md)(…) |  |
| [Log](CaptureLogBehavior/Log.md)(…) | Logs a capture log operation |
| [LogAsync](CaptureLogBehavior/LogAsync.md)(…) | Asynchronously logs a capture log operation |
| virtual [OnAudit](CaptureLogBehavior/OnAudit.md)(…) |  (3 methods) |
| override [OnAuditAsync](CaptureLogBehavior/OnAuditAsync.md)(…) |  (2 methods) |
| virtual [OnAuditAsync](CaptureLogBehavior/OnAuditAsync.md)(…) |  |

## See Also

* class [BaseSaveDeleteBehaviorAsync](./BaseSaveDeleteBehaviorAsync.md)
* interface [IDeleteBehaviorSync](./IDeleteBehaviorSync.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* interface [IUndeleteBehaviorAsync](./IUndeleteBehaviorAsync.md)
* interface [IUndeleteBehaviorSync](./IUndeleteBehaviorSync.md)
* **Source:** *[CaptureLogBehavior.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/IntegratedFeatures/CaptureLog/CaptureLogBehavior.cs)*