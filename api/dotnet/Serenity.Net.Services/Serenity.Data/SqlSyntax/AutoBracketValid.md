# SqlSyntax.AutoBracketValid method

Automatically brackets the string based on the dialect's `AutoQuotedIdentifier` setting, only if the identifier is valid.

```csharp
public static string AutoBracketValid(string s, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| s | The string. |
| dialect | Target dialect; [`DefaultDialect`](../SqlSettings/DefaultDialect.md) is used if null. |

## Return Value

The bracketed string.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSyntax](../SqlSyntax.md)