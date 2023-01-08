# TransactionlessUnitOfWork class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Unit of work implementation without an underlying actual transaction. Use with care only to pass a IUnitOfWork instance to some methods that you don't want to actually start a transaction.

```csharp
public class TransactionlessUnitOfWork : IDisposable, IUnitOfWork
```

## Public Members

| name | description |
| --- | --- |
| [TransactionlessUnitOfWork](TransactionlessUnitOfWork/TransactionlessUnitOfWork.md)(…) | Initializes a new instance of the class. |
| [Connection](TransactionlessUnitOfWork/Connection.md) { get; } | Gets the connection. |
| event [OnCommit](TransactionlessUnitOfWork/OnCommit.md) | Occurs when Commit is called as there is no underlying transaction. |
| event [OnRollback](TransactionlessUnitOfWork/OnRollback.md) | Occurs when Dispose is called as there is no underlying transaction. |
| [Commit](TransactionlessUnitOfWork/Commit.md)() | Does nothing other than calling onCommit events as there is no underlying transaction. |
| [Dispose](TransactionlessUnitOfWork/Dispose.md)() | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |

## See Also

* interface [IUnitOfWork](IUnitOfWork.md)
* **Source:** *[TransactionlessUnitOfWork.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/TransactionlessUnitOfWork.cs)*