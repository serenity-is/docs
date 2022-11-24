# ICaptureLogRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for capture logging row types

```csharp
public interface ICaptureLogRow : IIdRow
```

## Members

| name | description |
| --- | --- |
| [ChangingUserIdField](ICaptureLogRow/ChangingUserIdField.md) { get; } | Field containing the user ID |
| [OperationTypeField](ICaptureLogRow/OperationTypeField.md) { get; } | Field containing the operation type |
| [ValidFromField](ICaptureLogRow/ValidFromField.md) { get; } | Field containing ValidFrom date |
| [ValidUntilField](ICaptureLogRow/ValidUntilField.md) { get; } | Field containing ValidUntil date |

## See Also

* interface [IIdRow](../Serenity.Net.Entity/IIdRow.md)
* **Source:** *[ICaptureLogRow.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/IntegratedFeatures/CaptureLog/ICaptureLogRow.cs)*