# TransactionlessUnitOfWork class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A unit of work implementation without an underlying actual transaction. Use with care, only to pass an [`IUnitOfWork`](./IUnitOfWork.md) instance to some methods where you don't want to actually start a transaction.

```csharp
public class TransactionlessUnitOfWork : IAsyncDisposable, IDisposable, IUnitOfWork
```

| parameter | description |
| --- | --- |
| connection | The connection. |

## Public Members

| name | description |
| --- | --- |
| [TransactionlessUnitOfWork](TransactionlessUnitOfWork/TransactionlessUnitOfWork.md)(…) | A unit of work implementation without an underlying actual transaction. Use with care, only to pass an [`IUnitOfWork`](./IUnitOfWork.md) instance to some methods where you don't want to actually start a transaction. |
| [Connection](TransactionlessUnitOfWork/Connection.md) { get; } | Gets the connection. |
| [HasStartedTransaction](TransactionlessUnitOfWork/HasStartedTransaction.md) { get; } | Gets whether the unit of work's transaction was actually started. This implementation never starts one, so this always returns false. |
| event [OnCommit](TransactionlessUnitOfWork/OnCommit.md) | Occurs when Commit is called as there is no underlying transaction. Like [`OnCommit`](./UnitOfWork/OnCommit.md), this signals operation success, not a database transaction commit. |
| event [OnRollback](TransactionlessUnitOfWork/OnRollback.md) | Occurs when Dispose is called as there is no underlying transaction. |
| [Commit](TransactionlessUnitOfWork/Commit.md)() | Does nothing other than calling onCommit events as there is no underlying transaction. |
| [CommitAsync](TransactionlessUnitOfWork/CommitAsync.md)(…) | Does nothing other than calling onCommit events asynchronously as there is no underlying transaction. |
| [Dispose](TransactionlessUnitOfWork/Dispose.md)() | Invokes the rollback events, as there is no underlying transaction to roll back. |
| [DisposeAsync](TransactionlessUnitOfWork/DisposeAsync.md)() | Invokes the rollback events asynchronously, as there is no underlying transaction to roll back. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IUnitOfWork](./IUnitOfWork.md)
* **Source:** *[TransactionlessUnitOfWork.cs](https://github.com/serenity-is/Serenity/blob/2ba061e0b0144552c7ed59342da70ce1d8ca177c/src/services/Data/Connections/TransactionlessUnitOfWork.cs)*