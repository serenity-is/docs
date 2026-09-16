# UnitOfWork.CommitAsync method

Commits this transaction asynchronously.

```csharp
public Task CommitAsync(CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| cancellationToken | Cancellation token. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | Transaction is already committed! |

## See Also

* class [UnitOfWork](../UnitOfWork.md)