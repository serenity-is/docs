# JoinAliasLocator.ReplaceAliases method

Replaces the aliases in an SQL expression.

```csharp
public static string ReplaceAliases(string expression, Func<string, string> replace)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| replace | The replace function. |

## Return Value

The expression with aliases replaced.

## See Also

* class [JoinAliasLocator](../JoinAliasLocator.md)