# UnitOfWork class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Unit of work implementation.

```csharp
public class UnitOfWork : IDisposable, IUnitOfWork
```

## Public Members

| name | description |
| --- | --- |
| [UnitOfWork](UnitOfWork/UnitOfWork.md)(…) | Initializes a new instance of the [`UnitOfWork`](UnitOfWork.md) class. |
| [Connection](UnitOfWork/Connection.md) { get; } | Gets the connection. |
| event [OnCommit](UnitOfWork/OnCommit.md) | Occurs when transaction is committed. |
| event [OnRollback](UnitOfWork/OnRollback.md) | Occurs when transaction is rolled back. |
| [Commit](UnitOfWork/Commit.md)() | Commits this transaction. |
| [Dispose](UnitOfWork/Dispose.md)() | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. Rollbacks the transaction if any. |

## See Also

* interface [IUnitOfWork](IUnitOfWork.md)
* **Source:** *[UnitOfWork.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/UnitOfWork.cs)*