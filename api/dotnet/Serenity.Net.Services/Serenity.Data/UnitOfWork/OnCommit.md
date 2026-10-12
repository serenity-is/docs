# UnitOfWork.OnCommit event

Occurs when Commit completes without error. This signals operation success, not necessarily a database transaction commit: when no underlying transaction exists the event still fires.

```csharp
public event Action OnCommit;
```

## See Also

* class [UnitOfWork](../UnitOfWork.md)