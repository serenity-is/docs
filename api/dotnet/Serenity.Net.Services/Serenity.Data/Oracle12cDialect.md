# Oracle12cDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

SQL dialect for Oracle 12c, which uses OFFSET FETCH instead of ROWNUM.

```csharp
public class Oracle12cDialect : OracleDialect
```

## Public Members

| name | description |
| --- | --- |
| [Oracle12cDialect](Oracle12cDialect/Oracle12cDialect.md)() | The default constructor. |
| override [CanUseOffsetFetch](Oracle12cDialect/CanUseOffsetFetch.md) { get; } |  |
| override [OffsetFetchFormat](Oracle12cDialect/OffsetFetchFormat.md) { get; } |  |
| override [OffsetFormat](Oracle12cDialect/OffsetFormat.md) { get; } |  |
| static readonly [Instance](Oracle12cDialect/Instance.md) | The shared instance of Oracle12cDialect. |

## See Also

* class [OracleDialect](./OracleDialect.md)
* **Source:** *[Oracle12cDialect.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Dialects/Oracle12cDialect.cs)*