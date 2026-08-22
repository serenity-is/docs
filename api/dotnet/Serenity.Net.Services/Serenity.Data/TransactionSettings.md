# TransactionSettings class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Determines the transaction isolation level and defer start flag used for service endpoint actions when creating the [`UnitOfWork`](UnitOfWork.md) class.

```csharp
public class TransactionSettings
```

## Public Members

| name | description |
| --- | --- |
| [TransactionSettings](TransactionSettings/TransactionSettings.md)() | The default constructor. |
| [DeferStart](TransactionSettings/DeferStart.md) { get; set; } | Gets or sets the defer start flag. |
| [IsolationLevel](TransactionSettings/IsolationLevel.md) { get; set; } | Gets or sets the isolation level. |
| const [SectionKey](TransactionSettings/SectionKey.md) | The default section key for [`TransactionSettings`](TransactionSettings.md). |

## See Also

* **Source:** *[TransactionSettings.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Connections/TransactionSettings.cs)*