# SqlSyntax.AutoBracket method

Automatically brackets the string based on the [`AutoQuotedIdentifiers`](../SqlSettings/AutoQuotedIdentifiers.md) setting and keywords for the passed dialect.

```csharp
public static string AutoBracket(string s, ISqlDialect? dialect = null)
```

| parameter | description |
| --- | --- |
| s | The string. |
| dialect | The dialect. |

## Return Value

The bracketed string.

## Remarks

Brackets are always square here by design: they are the canonical pre-translation form, replaced with dialect quotes at execution time (see BracketLocator). Do not use dialect.QuoteIdentifier instead, as it is conditional on some dialects (e.g. Oracle, Firebird) and would silently drop the quoting intent for plain identifiers.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSyntax](../SqlSyntax.md)