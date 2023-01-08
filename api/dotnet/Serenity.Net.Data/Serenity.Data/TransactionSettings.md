# TransactionSettings class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Determines the transaction isolation level and defer start flag used for service endpoint action use when creating the UnitOfWork class

```csharp
public class TransactionSettings
```

## Public Members

| name | description |
| --- | --- |
| [TransactionSettings](TransactionSettings/TransactionSettings.md)() | The default constructor. |
| [DeferStart](TransactionSettings/DeferStart.md) { get; set; } | Gets sets the defer start flag |
| [IsolationLevel](TransactionSettings/IsolationLevel.md) { get; set; } | Gets sets the isolation level |
| const [SectionKey](TransactionSettings/SectionKey.md) | Default sectionkey for TransactionSettings |

## See Also

* **Source:** *[TransactionSettings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/TransactionSettings.cs)*