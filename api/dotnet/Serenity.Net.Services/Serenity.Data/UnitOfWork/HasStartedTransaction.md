# UnitOfWork.HasStartedTransaction property

Gets whether the unit of work's transaction was actually started. Unlike [`Initialized`](./Initialized.md), which is also true when the start was attempted but failed, this is only set after BeginTransaction succeeds. Once true it stays true, including after commit, rollback and dispose.

```csharp
public bool HasStartedTransaction { get; }
```

## See Also

* class [UnitOfWork](../UnitOfWork.md)