# Oracle12cDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Oracle12cDialect which uses OFFSET FETCH instead of ROWNUM

```csharp
public class Oracle12cDialect : OracleDialect
```

## Public Members

| name | description |
| --- | --- |
| [Oracle12cDialect](Oracle12cDialect/Oracle12cDialect.md)() | The default constructor. |
| override [CanUseOffsetFetch](Oracle12cDialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| override [OffsetFetchFormat](Oracle12cDialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| override [OffsetFormat](Oracle12cDialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| static readonly [Instance](Oracle12cDialect/Instance.md) | The shared instance of Oracle12cDialect. |

## See Also

* class [OracleDialect](OracleDialect.md)
* **Source:** *[Oracle12cDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/Oracle12cDialect.cs)*