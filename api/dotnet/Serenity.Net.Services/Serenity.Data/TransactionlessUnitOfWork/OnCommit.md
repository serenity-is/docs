# TransactionlessUnitOfWork.OnCommit event

Occurs when Commit is called as there is no underlying transaction. Like [`OnCommit`](../UnitOfWork/OnCommit.md), this signals operation success, not a database transaction commit.

```csharp
public event Action OnCommit;
```

## See Also

* class [TransactionlessUnitOfWork](../TransactionlessUnitOfWork.md)