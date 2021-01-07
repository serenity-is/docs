# DefaultConnectionStrings class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Default connection string source

```csharp
public class DefaultConnectionStrings : IConnectionStrings
```

## Public Members

| name | description |
| --- | --- |
| [DefaultConnectionStrings](DefaultConnectionStrings/DefaultConnectionStrings.md)(…) | Creates a new instance of DefaultConnectionStringSource |
| [ListConnectionStrings](DefaultConnectionStrings/ListConnectionStrings.md)() | Lists all known connections strings |
| [TryGetConnectionString](DefaultConnectionStrings/TryGetConnectionString.md)(…) | Gets a connection string by its key |

## Protected Members

| name | description |
| --- | --- |
| virtual [DetermineDialect](DefaultConnectionStrings/DetermineDialect.md)(…) | Determines dialect for a connection |

## See Also

* interface [IConnectionStrings](IConnectionStrings.md)
* **Source:** *[DefaultConnectionStrings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Connections/DefaultConnectionStrings.cs)*