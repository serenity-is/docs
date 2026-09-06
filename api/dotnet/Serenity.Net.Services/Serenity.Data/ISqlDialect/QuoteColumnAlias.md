# ISqlDialect.QuoteColumnAlias method

Quotes the column alias. This usually calls QuoteIdentifier except for Oracle.

```csharp
public string QuoteColumnAlias(string s)
```

| parameter | description |
| --- | --- |
| s | The column alias. |

## Return Value

The quoted column alias.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)