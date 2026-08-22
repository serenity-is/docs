# DefaultSqlConnections class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The default connection factory.

```csharp
public class DefaultSqlConnections : ISqlConnections
```

| parameter | description |
| --- | --- |
| connectionStrings | The named connection strings. |
| profiler | The profiler, if any. |
| loggerFactory | The optional logger factory (to be used by static SqlHelper methods). |

## Public Members

| name | description |
| --- | --- |
| [DefaultSqlConnections](DefaultSqlConnections/DefaultSqlConnections.md)(…) | The default connection factory. |
| [ListConnectionStrings](DefaultSqlConnections/ListConnectionStrings.md)() | Lists all known connection strings. |
| virtual [New](DefaultSqlConnections/New.md)(…) | Creates a new IDbConnection for the given connection string, provider name, and dialect. |
| virtual [NewByKey](DefaultSqlConnections/NewByKey.md)(…) | Creates a new IDbConnection for the given connection key. |
| virtual [TryGetConnectionString](DefaultSqlConnections/TryGetConnectionString.md)(…) | Gets a connection string by its key. |

## Protected Members

| name | description |
| --- | --- |
| readonly [connectionStrings-](DefaultSqlConnections/connectionStrings-.md) | The connection strings. |
| readonly [loggerFactory-](DefaultSqlConnections/loggerFactory-.md) | The logger factory. |
| readonly [profiler-](DefaultSqlConnections/profiler-.md) | The profiler. |
| virtual [CreateConnection](DefaultSqlConnections/CreateConnection.md)(…) | Creates an actual connection based on the provider name. This should not return a wrapped connection. |
| virtual [WrapConnection](DefaultSqlConnections/WrapConnection.md)(…) | Wraps and profiles the actual connection. |

## Remarks

Creates a new instance.

## See Also

* interface [ISqlConnections](ISqlConnections.md)
* **Source:** *[DefaultSqlConnections.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Connections/DefaultSqlConnections.cs)*