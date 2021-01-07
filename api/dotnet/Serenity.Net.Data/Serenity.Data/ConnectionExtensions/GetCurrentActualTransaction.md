# ConnectionExtensions.GetCurrentActualTransaction method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets the current actual transaction for a connection if any. Most of the time, a connection will only have one transaction, but in .NET it is not possible to know what is that transaction. Serenity wraps a connection (WrappedConnection) so that running transaction if any is available to get from the connection object.

```csharp
public static IDbTransaction GetCurrentActualTransaction(this IDbConnection connection)
```

| parameter | description |
| --- | --- |
| connection | The connection. |

## Return Value

The current transaction for a connection

## See Also

* class [ConnectionExtensions](../ConnectionExtensions.md)