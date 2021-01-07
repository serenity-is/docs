# WrappedTransaction class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Wraps a transaction instance to add current transaction support for the wrapped connection.

```csharp
public class WrappedTransaction : IDbTransaction, IHasActualTransaction
```

## Public Members

| name | description |
| --- | --- |
| [ActualTransaction](WrappedTransaction/ActualTransaction.md) { get; } | Returns the actual transaction. |
| [Connection](WrappedTransaction/Connection.md) { get; } | Returns the connection associated with this transaction. |
| [IsolationLevel](WrappedTransaction/IsolationLevel.md) { get; } | Returns the transaction isolation level |
| [Commit](WrappedTransaction/Commit.md)() | Commits actual transaction and sets wrapped transaction for related connection to null. |
| [Dispose](WrappedTransaction/Dispose.md)() | Rolbacks actual transaction and sets wrapped transaction for related connection to null. |
| [Rollback](WrappedTransaction/Rollback.md)() | Rollbacks actual transaction and sets wrapped transaction for related connection to null. |

## See Also

* interface [IHasActualTransaction](IHasActualTransaction.md)
* **Source:** *[WrappedTransaction.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/WrappedTransaction.cs)*