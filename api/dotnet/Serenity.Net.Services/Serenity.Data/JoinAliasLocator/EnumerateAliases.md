# JoinAliasLocator.EnumerateAliases method

Enumerates the aliases in an SQL expression.

```csharp
public static bool EnumerateAliases(string expression, Action<string> alias)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| alias | The alias handler action. |

## Return Value

`true` if the expression was processed successfully.

## See Also

* class [JoinAliasLocator](../JoinAliasLocator.md)