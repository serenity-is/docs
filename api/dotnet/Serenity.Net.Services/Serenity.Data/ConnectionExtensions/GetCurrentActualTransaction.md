# ConnectionExtensions.GetCurrentActualTransaction method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the current actual transaction for a connection, if any. Most of the time, a connection will only have one transaction, but in .NET it is not possible to know what that transaction is. Serenity wraps a connection ([`WrappedConnection`](../WrappedConnection.md)) so that the running transaction, if any, is available to get from the connection object.

```csharp
public static IDbTransaction GetCurrentActualTransaction(this IDbConnection connection)
```

| parameter | description |
| --- | --- |
| connection | The connection. |

## Return Value

The current transaction for the connection.

## See Also

* class [ConnectionExtensions](../ConnectionExtensions.md)