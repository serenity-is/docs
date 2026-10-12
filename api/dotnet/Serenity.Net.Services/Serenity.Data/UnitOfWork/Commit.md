# UnitOfWork.Commit method

Commits this transaction.

```csharp
public void Commit()
```

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | transaction |

## Remarks

When no underlying transaction exists (e.g. deferStart with a connection that was never opened) there is nothing to commit, but [`OnCommit`](./OnCommit.md) still fires as Commit completed without error. Check [`HasStartedTransaction`](./HasStartedTransaction.md) when it matters whether work actually ran transactionally.

## See Also

* class [UnitOfWork](../UnitOfWork.md)