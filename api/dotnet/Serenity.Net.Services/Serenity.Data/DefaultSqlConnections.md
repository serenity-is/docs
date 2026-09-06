# DefaultSqlConnections class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The default connection factory.

```csharp
public class DefaultSqlConnections : IConnectionKeyFallbacks, ISqlConnections
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
| [GetConnectionKeyFallbacks](DefaultSqlConnections/GetConnectionKeyFallbacks.md)(…) |  |
| [GetConnectionKeysResolvingTo](DefaultSqlConnections/GetConnectionKeysResolvingTo.md)(…) |  |
| [ListConnectionStrings](DefaultSqlConnections/ListConnectionStrings.md)() | Lists all known connection strings. |
| virtual [New](DefaultSqlConnections/New.md)(…) | Creates a new IDbConnection for the given connection string, provider name, and dialect. |
| virtual [NewByKey](DefaultSqlConnections/NewByKey.md)(…) | Creates a new IDbConnection for the given connection key. |
| [ResolveConnectionKey](DefaultSqlConnections/ResolveConnectionKey.md)(…) |  |
| virtual [TryGetConnectionString](DefaultSqlConnections/TryGetConnectionString.md)(…) | Gets a connection string by its key. |

## Protected Members

| name | description |
| --- | --- |
| readonly [connectionKeyFallbacks-](DefaultSqlConnections/connectionKeyFallbacks-.md) | The connection key fallbacks, if the connection string source supports them. |
| readonly [connectionStrings-](DefaultSqlConnections/connectionStrings-.md) | The connection strings. |
| readonly [loggerFactory-](DefaultSqlConnections/loggerFactory-.md) | The logger factory. |
| readonly [profiler-](DefaultSqlConnections/profiler-.md) | The profiler. |
| virtual [CreateConnection](DefaultSqlConnections/CreateConnection.md)(…) | Creates an actual connection based on the provider name. This should not return a wrapped connection. |
| virtual [WrapConnection](DefaultSqlConnections/WrapConnection.md)(…) | Wraps and profiles the actual connection. |

## Remarks

Creates a new instance.

## See Also

* interface [IConnectionKeyFallbacks](IConnectionKeyFallbacks.md)
* interface [ISqlConnections](ISqlConnections.md)
* **Source:** *[DefaultSqlConnections.cs](https://github.com/serenity-is/Serenity/blob/d7ef4960ed2723e5081d907f7610b7cabba6cf08/src/services/Data/Connections/DefaultSqlConnections.cs)*