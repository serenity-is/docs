# DefaultSqlDialectMapper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation of [`ISqlDialectMapper`](./ISqlDialectMapper.md) that maps well-known provider names and dialect type names to their corresponding [`ISqlDialect`](./ISqlDialect.md).

```csharp
public class DefaultSqlDialectMapper : ISqlDialectMapper
```

## Public Members

| name | description |
| --- | --- |
| [DefaultSqlDialectMapper](DefaultSqlDialectMapper/DefaultSqlDialectMapper.md)() | The default constructor. |
| [TryGet](DefaultSqlDialectMapper/TryGet.md)(…) | Returns the dialect for a dialect or provider name, or `null` if none is found. |

## See Also

* interface [ISqlDialectMapper](./ISqlDialectMapper.md)
* **Source:** *[DefaultSqlDialectMapper.cs](https://github.com/serenity-is/Serenity/blob/14083041af9d83edeb4eaac6738a5846bbaa8594/src/services/Data/Dialects/DefaultSqlDialectMapper.cs)*