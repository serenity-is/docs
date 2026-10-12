# IUnitOfWork.OnRollback event

Occurs when the unit of work is disposed without a prior Commit. Like [`OnCommit`](./OnCommit.md), this is tied to the operation outcome, not to a database transaction: it also fires when no underlying transaction was ever started.

```csharp
public event Action OnRollback;
```

## See Also

* interface [IUnitOfWork](../IUnitOfWork.md)