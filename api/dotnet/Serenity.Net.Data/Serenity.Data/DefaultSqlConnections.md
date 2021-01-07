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
| [TryGetConnectionString](DefaultSqlConnections/TryGetConnectionString.md)(…) | Gets a connection string by its key |

## See Also

* interface [ISqlConnections](ISqlConnections.md)
* **Source:** *[DefaultSqlConnections.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/DefaultSqlConnections.cs)*