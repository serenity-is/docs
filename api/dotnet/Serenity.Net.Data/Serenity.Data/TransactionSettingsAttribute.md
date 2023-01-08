# TransactionSettingsAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Determines the transaction isolation level and defer start flag used for a service endpoint action use when creating the UnitOfWork class

```csharp
[AttributeUsage(AttributeTargets.All)]
public class TransactionSettingsAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [TransactionSettingsAttribute](TransactionSettingsAttribute/TransactionSettingsAttribute.md)() | Initializes a new instance of the attribute. |
| [TransactionSettingsAttribute](TransactionSettingsAttribute/TransactionSettingsAttribute.md)(…) | Initializes a new instance of the attribute. |
| [DeferStart](TransactionSettingsAttribute/DeferStart.md) { get; set; } | Gets / sets if the transaction start should be deferred if possible (generally until the connection property of unit of work object is read). This might have undesired side effects so use with care. |
| [HasDeferStart](TransactionSettingsAttribute/HasDeferStart.md) { get; } | Gets if DeferStart property is set |
| [IsolationLevel](TransactionSettingsAttribute/IsolationLevel.md) { get; } | Gets the isolation level. |

## See Also

* **Source:** *[TransactionSettingsAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/TransactionSettingsAttribute.cs)*