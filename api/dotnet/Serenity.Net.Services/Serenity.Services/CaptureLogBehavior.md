# CaptureLogBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Capture log behavior

```csharp
public class CaptureLogBehavior : BaseSaveDeleteBehavior, IImplicitBehavior, IUndeleteBehavior
```

## Public Members

| name | description |
| --- | --- |
| [CaptureLogBehavior](CaptureLogBehavior/CaptureLogBehavior.md)() | The default constructor. |
| [ActivateFor](CaptureLogBehavior/ActivateFor.md)(…) |  |
| [Log](CaptureLogBehavior/Log.md)(…) | Logs a capture log operation |
| [OnAfterUndelete](CaptureLogBehavior/OnAfterUndelete.md)(…) |  |
| override [OnAudit](CaptureLogBehavior/OnAudit.md)(…) |  (2 methods) |
| [OnAudit](CaptureLogBehavior/OnAudit.md)(…) |  |
| [OnBeforeUndelete](CaptureLogBehavior/OnBeforeUndelete.md)(…) |  |
| [OnPrepareQuery](CaptureLogBehavior/OnPrepareQuery.md)(…) |  |
| [OnReturn](CaptureLogBehavior/OnReturn.md)(…) |  |
| [OnValidateRequest](CaptureLogBehavior/OnValidateRequest.md)(…) |  |

## See Also

* class [BaseSaveDeleteBehavior](BaseSaveDeleteBehavior.md)
* interface [IImplicitBehavior](IImplicitBehavior.md)
* interface [IUndeleteBehavior](IUndeleteBehavior.md)
* **Source:** *[CaptureLogBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/IntegratedFeatures/CaptureLog/CaptureLogBehavior.cs)*