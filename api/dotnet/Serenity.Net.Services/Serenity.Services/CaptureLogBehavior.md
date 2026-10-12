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

## Remarks

Writes a new capture log row for each audited change and closes the previous active row, similar to SQL Server temporal tables. The captured columns are exactly the table fields declared on the capture log row type, so a field is excluded by simply not declaring it on that row type. ValidFrom/ValidUntil values are stored as UTC unless those fields are explicitly annotated with Local. Capture log tables grow with every change and are not pruned automatically, so a periodic cleanup is recommended.

## See Also

* class [BaseSaveDeleteBehaviorAsync](./BaseSaveDeleteBehaviorAsync.md)
* interface [IDeleteBehaviorSync](./IDeleteBehaviorSync.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* interface [IUndeleteBehaviorAsync](./IUndeleteBehaviorAsync.md)
* interface [IUndeleteBehaviorSync](./IUndeleteBehaviorSync.md)
* **Source:** *[CaptureLogBehavior.cs](https://github.com/serenity-is/Serenity/blob/b0a5b5bb5553d59ed421adeb96e47c35c2e06051/src/services/RequestHandlers/IntegratedFeatures/CaptureLog/CaptureLogBehavior.cs)*