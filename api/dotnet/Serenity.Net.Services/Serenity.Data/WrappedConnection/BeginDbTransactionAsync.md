# WrappedConnection.BeginDbTransactionAsync method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Begins a database transaction asynchronously with the specified IsolationLevel value.

```csharp
protected override ValueTask<DbTransaction> BeginDbTransactionAsync(IsolationLevel isolationLevel, 
    CancellationToken cancellationToken)
```

| parameter | description |
| --- | --- |
| isolationLevel | One of the IsolationLevel values. |
| cancellationToken | The cancellation token. |

## Return Value

A value task that represents the asynchronous operation. The task result contains the new transaction.

## See Also

* class [WrappedConnection](../WrappedConnection.md)