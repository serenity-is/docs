# IUnitOfWork.OnCommit event

Occurs when Commit completes without error. This signals operation success, not necessarily a database transaction commit: when no underlying transaction exists (e.g. a deferred unit of work whose connection was never opened, or implementations without a real transaction) the event still fires. Check [`HasStartedTransaction`](./HasStartedTransaction.md) when it matters whether work actually ran transactionally.

```csharp
public event Action OnCommit;
```

## See Also

* interface [IUnitOfWork](../IUnitOfWork.md)