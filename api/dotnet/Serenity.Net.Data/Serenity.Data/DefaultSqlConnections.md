# DefaultSqlConnections class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Default connection factory

```csharp
public class DefaultSqlConnections : ISqlConnections
```

## Public Members

| name | description |
| --- | --- |
| [DefaultSqlConnections](DefaultSqlConnections/DefaultSqlConnections.md)(…) | Creates a new instance |
| [ListConnectionStrings](DefaultSqlConnections/ListConnectionStrings.md)() | Lists all known connections strings |
| virtual [New](DefaultSqlConnections/New.md)(…) | Creates a new IDbConnection for given connection string, provider name and dialect. |
| virtual [NewByKey](DefaultSqlConnections/NewByKey.md)(…) | Creates a new IDbConnection for given connection key. |
| virtual [TryGetConnectionString](DefaultSqlConnections/TryGetConnectionString.md)(…) | Gets a connection string by its key |

## Protected Members

| name | description |
| --- | --- |
| readonly [connectionStrings-](DefaultSqlConnections/connectionStrings-.md) | Connection strings |
| readonly [loggerFactory-](DefaultSqlConnections/loggerFactory-.md) | Logger factory |
| readonly [profiler-](DefaultSqlConnections/profiler-.md) | Profiler |
| virtual [CreateConnection](DefaultSqlConnections/CreateConnection.md)(…) | Creates an actual connection based on providerName, this should not return a wrapped connection. |
| virtual [WrapConnection](DefaultSqlConnections/WrapConnection.md)(…) | Wraps and profiles the actual connection |

## See Also

* interface [ISqlConnections](ISqlConnections.md)
* **Source:** *[DefaultSqlConnections.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/DefaultSqlConnections.cs)*