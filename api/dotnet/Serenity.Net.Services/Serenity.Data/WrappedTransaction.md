# WrappedTransaction class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps a transaction instance to add current transaction support for the wrapped connection.

```csharp
public class WrappedTransaction : DbTransaction, IHasActualTransaction
```

## Public Members

| name | description |
| --- | --- |
| [ActualTransaction](WrappedTransaction/ActualTransaction.md) { get; } | Returns the actual transaction. |
| override [IsolationLevel](WrappedTransaction/IsolationLevel.md) { get; } | Returns the transaction isolation level |
| override [Commit](WrappedTransaction/Commit.md)() | Commits actual transaction and sets wrapped transaction for related connection to null. |
| override [CommitAsync](WrappedTransaction/CommitAsync.md)(…) | Commits actual transaction asynchronously and sets wrapped transaction for related connection to null. |
| override [DisposeAsync](WrappedTransaction/DisposeAsync.md)() | Disposes actual transaction asynchronously and sets wrapped transaction for related connection to null. |
| override [Rollback](WrappedTransaction/Rollback.md)() | Rollbacks actual transaction and sets wrapped transaction for related connection to null. |
| override [RollbackAsync](WrappedTransaction/RollbackAsync.md)(…) | Rollbacks actual transaction asynchronously and sets wrapped transaction for related connection to null. |

## Protected Members

| name | description |
| --- | --- |
| override [DbConnection](WrappedTransaction/DbConnection.md) { get; } | Returns the connection associated with this transaction. |
| override [Dispose](WrappedTransaction/Dispose.md)(…) | Disposes actual transaction and sets wrapped transaction for related connection to null. |

## See Also

* interface [IHasActualTransaction](IHasActualTransaction.md)
* **Source:** *[WrappedTransaction.cs](https://github.com/serenity-is/Serenity/blob/9a6b298b9db4a9b7c6735a792f30882f8be62d68/src/services/Data/Connections/WrappedTransaction.cs)*