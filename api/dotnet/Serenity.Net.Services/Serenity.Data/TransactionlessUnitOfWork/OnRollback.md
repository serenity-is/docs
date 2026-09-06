# TransactionlessUnitOfWork.OnRollback event

Occurs when Dispose is called as there is no underlying transaction.

```csharp
public event Action OnRollback;
```

## See Also

* class [TransactionlessUnitOfWork](../TransactionlessUnitOfWork.md)