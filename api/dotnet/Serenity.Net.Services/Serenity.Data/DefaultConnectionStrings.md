# DefaultConnectionStrings class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default connection string source

```csharp
public class DefaultConnectionStrings : IConnectionStrings
```

| parameter | description |
| --- | --- |
| options | Connection string options |
| sqlDialectMapper | Sql Dialect Mapper |

## Public Members

| name | description |
| --- | --- |
| [DefaultConnectionStrings](DefaultConnectionStrings/DefaultConnectionStrings.md)(…) | Default connection string source |
| virtual [ListConnectionStrings](DefaultConnectionStrings/ListConnectionStrings.md)() | Lists all known connections strings |
| virtual [TryGetConnectionString](DefaultConnectionStrings/TryGetConnectionString.md)(…) | Gets a connection string by its key |

## Protected Members

| name | description |
| --- | --- |
| readonly [byKey-](DefaultConnectionStrings/byKey-.md) | Cached dictionary of connection string infos |
| readonly [options-](DefaultConnectionStrings/options-.md) | Options |
| readonly [sqlDialectMapper-](DefaultConnectionStrings/sqlDialectMapper-.md) | Sql dialect mapper |
| virtual [DetermineDialect](DefaultConnectionStrings/DetermineDialect.md)(…) | Determines dialect for a connection |

## Remarks

Creates a new instance of DefaultConnectionStringSource

## See Also

* interface [IConnectionStrings](IConnectionStrings.md)
* **Source:** *[DefaultConnectionStrings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Connections/DefaultConnectionStrings.cs)*