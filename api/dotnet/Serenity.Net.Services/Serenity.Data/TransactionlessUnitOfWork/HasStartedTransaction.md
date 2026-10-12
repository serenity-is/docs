# TransactionlessUnitOfWork.HasStartedTransaction property

Gets whether the unit of work's transaction was actually started. This implementation never starts one, so this always returns false.

```csharp
public bool HasStartedTransaction { get; }
```

## See Also

* class [TransactionlessUnitOfWork](../TransactionlessUnitOfWork.md)