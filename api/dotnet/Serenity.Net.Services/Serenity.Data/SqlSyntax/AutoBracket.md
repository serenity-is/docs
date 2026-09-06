# SqlSyntax.AutoBracket method

Automatically brackets the string based on the [`AutoQuotedIdentifiers`](../SqlSettings/AutoQuotedIdentifiers.md) setting and keywords for the passed dialect.

```csharp
public static string AutoBracket(string s, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| s | The string. |
| dialect | The dialect. |

## Return Value

The bracketed string.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSyntax](../SqlSyntax.md)