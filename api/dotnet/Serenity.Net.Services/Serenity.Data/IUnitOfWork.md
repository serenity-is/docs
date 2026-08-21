# IUnitOfWork interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An interface to implement the unit of work pattern, e.g. a transaction.

```csharp
public interface IUnitOfWork
```

## Members

| name | description |
| --- | --- |
| [Connection](IUnitOfWork/Connection.md) { get; } | Gets the connection. |
| event [OnCommit](IUnitOfWork/OnCommit.md) | Occurs when the transaction is committed. |
| event [OnRollback](IUnitOfWork/OnRollback.md) | Occurs when the transaction is rolled back. |

## See Also

* **Source:** *[IUnitOfWork.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Connections/IUnitOfWork.cs)*