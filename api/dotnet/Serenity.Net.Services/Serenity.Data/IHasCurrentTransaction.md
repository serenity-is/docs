# IHasCurrentTransaction interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for types that have a [`CurrentTransaction`](./IHasCurrentTransaction/CurrentTransaction.md) property of type IDbTransaction.

```csharp
public interface IHasCurrentTransaction
```

## Members

| name | description |
| --- | --- |
| [CurrentTransaction](IHasCurrentTransaction/CurrentTransaction.md) { get; } | Gets the current transaction, if any. |

## See Also

* **Source:** *[IHasCurrentTransaction.cs](https://github.com/serenity-is/Serenity/blob/03d9544633af3a843d9921adc3e91fceec981ad4/src/services/Data/Connections/IHasCurrentTransaction.cs)*