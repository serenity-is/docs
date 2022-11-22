# ConnectionExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Contains DB connection related extensions

```csharp
public static class ConnectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| const [DefaultConnectionKey](ConnectionExtensions/DefaultConnectionKey.md) | Default connection key, this is an optional name |
| static [EnsureOpen](ConnectionExtensions/EnsureOpen.md)(…) | Ensures the connection is open. Warning! This method will not reopen a connection that once was opened and will raise an error. |
| static [GetCurrentActualTransaction](ConnectionExtensions/GetCurrentActualTransaction.md)(…) | Gets the current actual transaction for a connection if any. Most of the time, a connection will only have one transaction, but in .NET it is not possible to know what is that transaction. Serenity wraps a connection (WrappedConnection) so that running transaction if any is available to get from the connection object. |
| static [GetDialect](ConnectionExtensions/GetDialect.md)(…) | Gets the dialect for given connection. |
| static [GetLogger](ConnectionExtensions/GetLogger.md)(…) | Gets the logger for a connection if it implements IHasLogger interface, or null if not. |
| static [NewFor&lt;TClass&gt;](ConnectionExtensions/NewFor.md)(…) | Creates a new connection for specified class, determining the connection key by checking its [ConnectionKey] attribute. |
| static [SetCommandTimeout](ConnectionExtensions/SetCommandTimeout.md)(…) | Sets the default command timeout for given connection. Only works with IHasCommandTimeout (WrappedConnection) instances, which are usually created by SqlConnections.NewXyz methods. |

## See Also

* **Source:** *[ConnectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/ConnectionExtensions.cs)*