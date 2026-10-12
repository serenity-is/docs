# SqlSyntax.AutoBracketValid method

Automatically brackets the string based on the dialect's `AutoQuotedIdentifier` setting, only if the identifier is valid.

```csharp
public static string? AutoBracketValid(string? s, ISqlDialect? dialect = null)
```

| parameter | description |
| --- | --- |
| s | The string. |
| dialect | Target dialect; [`DefaultDialect`](../SqlSettings/DefaultDialect.md) is used if null. |

## Return Value

The bracketed string.

## Remarks

This method only brackets unquoted, simple identifiers. It deliberately does not try to recognize names containing spaces (or other characters that make them invalid simple identifiers), because its input may instead be a subquery, function call, or other SQL expression. Such table or column names must be bracketed by the caller, for example `[Some Table]` in a `TableName` definition or `.Select("[Some Column]")`. Handling those ambiguous names is not this method's responsibility.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSyntax](../SqlSyntax.md)