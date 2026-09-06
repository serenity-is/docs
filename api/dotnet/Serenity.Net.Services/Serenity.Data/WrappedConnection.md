# WrappedConnection class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Wraps a connection to add current transaction and dialect support.

```csharp
public class WrappedConnection : DbConnection, IHasActualConnection, IHasCommandTimeout, 
    IHasConnectionStateChange, IHasCurrentTransaction, IHasDialect, IHasLogger, IHasOpenedOnce
```

## Public Members

| name | description |
| --- | --- |
| [WrappedConnection](WrappedConnection/WrappedConnection.md)(…) | Initializes a new instance of the [`WrappedConnection`](WrappedConnection.md) class. |
| [ActualConnection](WrappedConnection/ActualConnection.md) { get; } | Gets the actual connection instance. |
| [CommandTimeout](WrappedConnection/CommandTimeout.md) { get; set; } | Gets or sets default command timeout. |
| override [ConnectionString](WrappedConnection/ConnectionString.md) { get; set; } | Gets or sets the string used to open a database. |
| override [ConnectionTimeout](WrappedConnection/ConnectionTimeout.md) { get; } | Gets the time to wait while trying to establish a connection before terminating the attempt and generating an error. |
| [CurrentTransaction](WrappedConnection/CurrentTransaction.md) { get; } | Gets the current transaction. |
| override [Database](WrappedConnection/Database.md) { get; } | Gets the name of the current database or the database to be used after a connection is opened. |
| override [DataSource](WrappedConnection/DataSource.md) { get; } | Gets the name of the database server to which to connect. |
| [Dialect](WrappedConnection/Dialect.md) { get; set; } | Gets or sets the SQL dialect. |
| [Logger](WrappedConnection/Logger.md) { get; } | Gets the logger instance for this connection, if any. |
| [OpenedOnce](WrappedConnection/OpenedOnce.md) { get; } | Gets a value indicating whether the connection was opened once. |
| override [ServerVersion](WrappedConnection/ServerVersion.md) { get; } | Gets the version of the database server. |
| override [State](WrappedConnection/State.md) { get; } | Gets the current state of the connection. |
| override [ChangeDatabase](WrappedConnection/ChangeDatabase.md)(…) | Changes the current database for an open Connection object. |
| override [Close](WrappedConnection/Close.md)() | Closes the connection to the database. |
| override [CloseAsync](WrappedConnection/CloseAsync.md)() | Closes the connection to the database asynchronously. |
| override [DisposeAsync](WrappedConnection/DisposeAsync.md)() | Disposes the actual connection asynchronously. |
| override [Open](WrappedConnection/Open.md)() | Opens a database connection with the settings specified by the ConnectionString property of the provider-specific Connection object. |
| override [OpenAsync](WrappedConnection/OpenAsync.md)(…) | Opens a database connection asynchronously with the settings specified by the ConnectionString property of the provider-specific Connection object. |

## Protected Members

| name | description |
| --- | --- |
| override [DbProviderFactory](WrappedConnection/DbProviderFactory.md) { get; } | Gets the associated provider factory for the connection, or `null` if the actual connection is not a DbConnection. |
| override [BeginDbTransaction](WrappedConnection/BeginDbTransaction.md)(…) | Begins a database transaction with the specified IsolationLevel value. |
| override [BeginDbTransactionAsync](WrappedConnection/BeginDbTransactionAsync.md)(…) | Begins a database transaction asynchronously with the specified IsolationLevel value. |
| override [CreateDbCommand](WrappedConnection/CreateDbCommand.md)() | Creates and returns a Command object associated with the connection. |
| override [Dispose](WrappedConnection/Dispose.md)(…) | Disposes the actual connection. |

## See Also

* interface [IHasActualConnection](IHasActualConnection.md)
* interface [IHasCommandTimeout](IHasCommandTimeout.md)
* interface [IHasConnectionStateChange](IHasConnectionStateChange.md)
* interface [IHasCurrentTransaction](IHasCurrentTransaction.md)
* interface [IHasDialect](IHasDialect.md)
* interface [IHasLogger](IHasLogger.md)
* interface [IHasOpenedOnce](IHasOpenedOnce.md)
* **Source:** *[WrappedConnection.cs](https://github.com/serenity-is/Serenity/blob/9a6b298b9db4a9b7c6735a792f30882f8be62d68/src/services/Data/Connections/WrappedConnection.cs)*