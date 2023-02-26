# SqlServer2012Dialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Sql Server 2012 dialect.

```csharp
public class SqlServer2012Dialect : SqlServer2008Dialect
```

## Public Members

| name | description |
| --- | --- |
| [SqlServer2012Dialect](SqlServer2012Dialect/SqlServer2012Dialect.md)() | The default constructor. |
| override [CanUseConcat](SqlServer2012Dialect/CanUseConcat.md) { get; } |  |
| override [CanUseOffsetFetch](SqlServer2012Dialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| override [OffsetFetchFormat](SqlServer2012Dialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| override [OffsetFormat](SqlServer2012Dialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| static readonly [Instance](SqlServer2012Dialect/Instance.md) | The shared instance of SqlServer2012Dialect. |

## See Also

* class [SqlServer2008Dialect](SqlServer2008Dialect.md)
* **Source:** *[SqlServer2012Dialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/SqlServer2012Dialect.cs)*