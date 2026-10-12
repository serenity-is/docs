# IUnitOfWork.HasStartedTransaction property

Gets whether the unit of work's transaction was actually started. A normal unit of work starts its transaction right away, so the default implementation returns true. Implementations with deferred or no transaction override this with the real state: it stays false until the transaction is successfully started, e.g. for a deferred unit of work whose connection was never opened. Once true it stays true, including after commit, rollback and dispose, so it can reliably be read from OnCommit / OnRollback handlers and after the fact.

```csharp
public bool HasStartedTransaction { get; }
```

## See Also

* interface [IUnitOfWork](../IUnitOfWork.md)