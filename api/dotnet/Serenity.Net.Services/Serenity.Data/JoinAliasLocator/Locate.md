# JoinAliasLocator.Locate method

Locates the aliases in specified expression.

```csharp
public static HashSet<string> Locate(string expression)
```

| parameter | description |
| --- | --- |
| expression | The expression. |

## Return Value

The set of aliases found, or `null` if none are found.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | expression is null. |

## See Also

* class [JoinAliasLocator](../JoinAliasLocator.md)