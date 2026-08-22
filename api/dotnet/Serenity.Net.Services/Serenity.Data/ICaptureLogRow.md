# ICaptureLogRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for capture logging row types

```csharp
public interface ICaptureLogRow : IIdRow
```

## Members

| name | description |
| --- | --- |
| [ChangingUserIdField](ICaptureLogRow/ChangingUserIdField.md) { get; } | Gets the field containing the user ID. |
| [OperationTypeField](ICaptureLogRow/OperationTypeField.md) { get; } | Gets the field containing the operation type. |
| [ValidFromField](ICaptureLogRow/ValidFromField.md) { get; } | Gets the field containing the ValidFrom date. |
| [ValidUntilField](ICaptureLogRow/ValidUntilField.md) { get; } | Gets the field containing the ValidUntil date. |

## See Also

* interface [IIdRow](IIdRow.md)
* **Source:** *[ICaptureLogRow.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/IntegratedFeatures/CaptureLog/ICaptureLogRow.cs)*