# WrappedConnection class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Wraps a connection to add current transaction and dialect support.

```csharp
public class WrappedConnection : IDbConnection, IHasActualConnection, IHasCommandTimeout, 
    IHasCurrentTransaction, IHasDialect, IHasLogger, IHasOpenedOnce
```

## Public Members

| name | description |
| --- | --- |
| [WrappedConnection](WrappedConnection/WrappedConnection.md)(…) | Initializes a new instance of the [`WrappedConnection`](WrappedConnection.md) class. |
| [ActualConnection](WrappedConnection/ActualConnection.md) { get; } | Gets the actual connection instance. |
| [CommandTimeout](WrappedConnection/CommandTimeout.md) { get; set; } | Gets or sets default command timeout. |
| [ConnectionString](WrappedConnection/ConnectionString.md) { get; set; } | Gets or sets the string used to open a database. |
| [ConnectionTimeout](WrappedConnection/ConnectionTimeout.md) { get; } | Gets the time to wait while trying to establish a connection before terminating the attempt and generating an error. |
| [CurrentTransaction](WrappedConnection/CurrentTransaction.md) { get; } | Gets the current transaction. |
| [Database](WrappedConnection/Database.md) { get; } | Gets the name of the current database or the database to be used after a connection is opened. |
| [Dialect](WrappedConnection/Dialect.md) { get; set; } | Gets or sets the SQL dialect. |
| [Logger](WrappedConnection/Logger.md) { get; } | Gets the logger instance for this connection if any |
| [OpenedOnce](WrappedConnection/OpenedOnce.md) { get; } | Gets a value indicating whether the connection was opened once. |
| [State](WrappedConnection/State.md) { get; } | Gets the current state of the connection. |
| [BeginTransaction](WrappedConnection/BeginTransaction.md)() | Begins a database transaction. |
| [BeginTransaction](WrappedConnection/BeginTransaction.md)(…) | Begins a database transaction with the specified IsolationLevel value. |
| [ChangeDatabase](WrappedConnection/ChangeDatabase.md)(…) | Changes the current database for an open Connection object. |
| [Close](WrappedConnection/Close.md)() | Closes the connection to the database. |
| [CreateCommand](WrappedConnection/CreateCommand.md)() | Creates and returns a Command object associated with the connection. |
| [Dispose](WrappedConnection/Dispose.md)() | Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. |
| [Open](WrappedConnection/Open.md)() | Opens a database connection with the settings specified by the ConnectionString property of the provider-specific Connection object. |

## See Also

* interface [IHasActualConnection](IHasActualConnection.md)
* interface [IHasCommandTimeout](IHasCommandTimeout.md)
* interface [IHasCurrentTransaction](IHasCurrentTransaction.md)
* interface [IHasDialect](IHasDialect.md)
* interface [IHasLogger](IHasLogger.md)
* interface [IHasOpenedOnce](IHasOpenedOnce.md)
* **Source:** *[WrappedConnection.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/WrappedConnection.cs)*