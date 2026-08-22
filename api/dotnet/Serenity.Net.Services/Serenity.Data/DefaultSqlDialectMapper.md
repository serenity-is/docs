# DefaultSqlDialectMapper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation of [`ISqlDialectMapper`](ISqlDialectMapper.md) that maps well-known provider names and dialect type names to their corresponding [`ISqlDialect`](ISqlDialect.md).

```csharp
public class DefaultSqlDialectMapper : ISqlDialectMapper
```

## Public Members

| name | description |
| --- | --- |
| [DefaultSqlDialectMapper](DefaultSqlDialectMapper/DefaultSqlDialectMapper.md)() | The default constructor. |
| [TryGet](DefaultSqlDialectMapper/TryGet.md)(…) | Returns the dialect for a dialect or provider name, or `null` if none is found. |

## See Also

* interface [ISqlDialectMapper](ISqlDialectMapper.md)
* **Source:** *[DefaultSqlDialectMapper.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Dialects/DefaultSqlDialectMapper.cs)*