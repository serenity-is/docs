# WrappedConnection.BeginDbTransaction method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Begins a database transaction with the specified IsolationLevel value.

```csharp
protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
```

| parameter | description |
| --- | --- |
| isolationLevel | One of the IsolationLevel values. |

## Return Value

An object representing the new transaction.

## See Also

* class [WrappedConnection](../WrappedConnection.md)