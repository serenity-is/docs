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
| [HasStartedTransaction](IUnitOfWork/HasStartedTransaction.md) { get; } | Gets whether the unit of work's transaction was actually started. A normal unit of work starts its transaction right away, so the default implementation returns true. Implementations with deferred or no transaction override this with the real state: it stays false until the transaction is successfully started, e.g. for a deferred unit of work whose connection was never opened. Once true it stays true, including after commit, rollback and dispose, so it can reliably be read from OnCommit / OnRollback handlers and after the fact. |
| event [OnCommit](IUnitOfWork/OnCommit.md) | Occurs when Commit completes without error. This signals operation success, not necessarily a database transaction commit: when no underlying transaction exists (e.g. a deferred unit of work whose connection was never opened, or implementations without a real transaction) the event still fires. Check [`HasStartedTransaction`](./IUnitOfWork/HasStartedTransaction.md) when it matters whether work actually ran transactionally. |
| event [OnRollback](IUnitOfWork/OnRollback.md) | Occurs when the unit of work is disposed without a prior Commit. Like [`OnCommit`](./IUnitOfWork/OnCommit.md), this is tied to the operation outcome, not to a database transaction: it also fires when no underlying transaction was ever started. |

## See Also

* **Source:** *[IUnitOfWork.cs](https://github.com/serenity-is/Serenity/blob/2ba061e0b0144552c7ed59342da70ce1d8ca177c/src/services/Data/Connections/IUnitOfWork.cs)*