# UnitOfWork class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Unit of work implementation.

```csharp
public class UnitOfWork : IDisposable, IUnitOfWork
```

## Public Members

| name | description |
| --- | --- |
| [UnitOfWork](UnitOfWork/UnitOfWork.md)(…) | Initializes a new instance of the [`UnitOfWork`](./UnitOfWork.md) class. (3 constructors) |
| [Connection](UnitOfWork/Connection.md) { get; } | Gets the connection. |
| [Initialized](UnitOfWork/Initialized.md) { get; } | Returns true if the transaction is tried to be started at least once. This always returns true if deferStart is not true. |
| event [OnCommit](UnitOfWork/OnCommit.md) | Occurs when transaction is committed. |
| event [OnRollback](UnitOfWork/OnRollback.md) | Occurs when transaction is rolled back. |
| [Commit](UnitOfWork/Commit.md)() | Commits this transaction. |
| [CommitAsync](UnitOfWork/CommitAsync.md)(…) | Commits this transaction asynchronously. |
| [Dispose](UnitOfWork/Dispose.md)() | Rollbacks the transaction if any and calls onRollback event. |
| [DisposeAsync](UnitOfWork/DisposeAsync.md)() | Rollbacks the transaction if any and calls onRollback event asynchronously. |

## See Also

* interface [IUnitOfWork](./IUnitOfWork.md)
* **Source:** *[UnitOfWork.cs](https://github.com/serenity-is/Serenity/blob/51c903b5f428c7969f62fffda94e0024919a43f5/src/services/Data/Connections/UnitOfWork.cs)*