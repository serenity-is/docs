# TransactionSettingsAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Determines the transaction isolation level and defer start flag used for a service endpoint action when creating the [`UnitOfWork`](./UnitOfWork.md) class.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class TransactionSettingsAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [TransactionSettingsAttribute](TransactionSettingsAttribute/TransactionSettingsAttribute.md)() | Initializes a new instance of the attribute. |
| [TransactionSettingsAttribute](TransactionSettingsAttribute/TransactionSettingsAttribute.md)(…) | Initializes a new instance of the attribute. |
| [DeferStart](TransactionSettingsAttribute/DeferStart.md) { get; set; } | Gets or sets whether the transaction start should be deferred if possible (generally until the connection property of the unit of work object is read). This might have undesired side effects, so use with care. |
| [HasDeferStart](TransactionSettingsAttribute/HasDeferStart.md) { get; } | Gets whether the [`DeferStart`](./TransactionSettingsAttribute/DeferStart.md) property is set. |
| [IsolationLevel](TransactionSettingsAttribute/IsolationLevel.md) { get; } | Gets the isolation level. |

## See Also

* **Source:** *[TransactionSettingsAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Connections/TransactionSettingsAttribute.cs)*