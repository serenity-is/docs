# ISqlConnections interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An interface used to abstract SQL connections.

```csharp
public interface ISqlConnections : IConnectionStrings
```

## Members

| name | description |
| --- | --- |
| [New](ISqlConnections/New.md)(…) | Creates a new IDbConnection for the given connection string, provider name, and dialect. |
| [NewByKey](ISqlConnections/NewByKey.md)(…) | Creates a new IDbConnection for the given connection key. |

## See Also

* interface [IConnectionStrings](IConnectionStrings.md)
* **Source:** *[ISqlConnections.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Connections/ISqlConnections.cs)*