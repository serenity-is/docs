# DefaultConnectionStrings class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The default connection string source.

```csharp
public class DefaultConnectionStrings : IConnectionStrings
```

| parameter | description |
| --- | --- |
| options | The connection string options. |
| sqlDialectMapper | The SQL dialect mapper. |

## Public Members

| name | description |
| --- | --- |
| [DefaultConnectionStrings](DefaultConnectionStrings/DefaultConnectionStrings.md)(…) | The default connection string source. |
| virtual [ListConnectionStrings](DefaultConnectionStrings/ListConnectionStrings.md)() | Lists all known connection strings. |
| virtual [TryGetConnectionString](DefaultConnectionStrings/TryGetConnectionString.md)(…) | Gets a connection string by its key. |

## Protected Members

| name | description |
| --- | --- |
| readonly [byKey-](DefaultConnectionStrings/byKey-.md) | The cached dictionary of connection string infos. |
| readonly [options-](DefaultConnectionStrings/options-.md) | The options. |
| readonly [sqlDialectMapper-](DefaultConnectionStrings/sqlDialectMapper-.md) | The SQL dialect mapper. |
| virtual [DetermineDialect](DefaultConnectionStrings/DetermineDialect.md)(…) | Determines the dialect for a connection. |

## Remarks

Creates a new instance of [`DefaultConnectionStrings`](DefaultConnectionStrings.md).

## See Also

* interface [IConnectionStrings](IConnectionStrings.md)
* **Source:** *[DefaultConnectionStrings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Connections/DefaultConnectionStrings.cs)*