# TransactionlessUnitOfWork constructor

A unit of work implementation without an underlying actual transaction. Use with care, only to pass an [`IUnitOfWork`](../IUnitOfWork.md) instance to some methods where you don't want to actually start a transaction.

```csharp
public TransactionlessUnitOfWork(IDbConnection connection)
```

| parameter | description |
| --- | --- |
| connection | The connection. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IUnitOfWork](../IUnitOfWork.md)
* class [TransactionlessUnitOfWork](../TransactionlessUnitOfWork.md)