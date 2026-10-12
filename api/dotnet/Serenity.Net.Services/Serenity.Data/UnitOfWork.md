# UnitOfWork class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Unit of work implementation.

```csharp
public class UnitOfWork : IAsyncDisposable, IDisposable, IUnitOfWork
```

## Public Members

| name | description |
| --- | --- |
| [UnitOfWork](UnitOfWork/UnitOfWork.md)(…) | Initializes a new instance of the [`UnitOfWork`](./UnitOfWork.md) class. (3 constructors) |
| [Connection](UnitOfWork/Connection.md) { get; } | Gets the connection. |
| [HasStartedTransaction](UnitOfWork/HasStartedTransaction.md) { get; } | Gets whether the unit of work's transaction was actually started. Unlike [`Initialized`](./UnitOfWork/Initialized.md), which is also true when the start was attempted but failed, this is only set after BeginTransaction succeeds. Once true it stays true, including after commit, rollback and dispose. |
| [Initialized](UnitOfWork/Initialized.md) { get; } | Returns true if the transaction is tried to be started at least once. This always returns true if deferStart is not true. |
| event [OnCommit](UnitOfWork/OnCommit.md) | Occurs when Commit completes without error. This signals operation success, not necessarily a database transaction commit: when no underlying transaction exists the event still fires. |
| event [OnRollback](UnitOfWork/OnRollback.md) | Occurs when the unit of work is disposed without a prior Commit. This is tied to the operation outcome, not to a database transaction: it also fires when no underlying transaction was ever started. |
| [Commit](UnitOfWork/Commit.md)() | Commits this transaction. |
| [CommitAsync](UnitOfWork/CommitAsync.md)(…) | Commits this transaction asynchronously. |
| [Dispose](UnitOfWork/Dispose.md)() | Rollbacks the transaction if any and calls onRollback event. |
| [DisposeAsync](UnitOfWork/DisposeAsync.md)() | Rollbacks the transaction if any and calls onRollback event asynchronously. |

## See Also

* interface [IUnitOfWork](./IUnitOfWork.md)
* **Source:** *[UnitOfWork.cs](https://github.com/serenity-is/Serenity/blob/1392b4369641995f827c83d41ecbea28e6631650/src/services/Data/Connections/UnitOfWork.cs)*