# ISqlConnections interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

An interface used to abstract sql connections

```csharp
public interface ISqlConnections : IConnectionStrings
```

## Members

| name | description |
| --- | --- |
| [New](ISqlConnections/New.md)(…) | Creates a new IDbConnection for given connection string, provider name and dialect. |
| [NewByKey](ISqlConnections/NewByKey.md)(…) | Creates a new IDbConnection for given connection key. |

## See Also

* interface [IConnectionStrings](IConnectionStrings.md)
* **Source:** *[ISqlConnections.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/ISqlConnections.cs)*