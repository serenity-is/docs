# UnitOfWork.OnRollback event

Occurs when the unit of work is disposed without a prior Commit. This is tied to the operation outcome, not to a database transaction: it also fires when no underlying transaction was ever started.

```csharp
public event Action OnRollback;
```

## See Also

* class [UnitOfWork](../UnitOfWork.md)