# TransactionlessUnitOfWork constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Unit of work implementation without an underlying actual transaction. Use with care only to pass a IUnitOfWork instance to some methods that you don't want to actually start a transaction.

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