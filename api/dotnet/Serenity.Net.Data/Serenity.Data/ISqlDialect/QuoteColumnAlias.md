# ISqlDialect.QuoteColumnAlias method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Quotes the column alias. This usually calls QuoteIdentifier except for Oracle.

```csharp
public string QuoteColumnAlias(string s)
```

| parameter | description |
| --- | --- |
| s | The column alias. |

## Return Value

Quoted column alias

## See Also

* interface [ISqlDialect](../ISqlDialect.md)