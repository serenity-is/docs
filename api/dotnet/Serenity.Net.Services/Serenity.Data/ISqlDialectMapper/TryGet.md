# ISqlDialectMapper.TryGet method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns the dialect for a dialect or provider name, or `null` if none is found.

```csharp
public ISqlDialect TryGet(string dialectOrProviderName)
```

| parameter | description |
| --- | --- |
| dialectOrProviderName | The dialect name or provider name. |

## Return Value

The matching [`ISqlDialect`](../ISqlDialect.md), or `null` if no match is found.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* interface [ISqlDialectMapper](../ISqlDialectMapper.md)