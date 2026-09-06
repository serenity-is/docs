# PermissionExpressionParser.Tokenize method

Tokenizes a permission expression into individual operators, parentheses, and permission keys.

```csharp
public static IEnumerable<string> Tokenize(string expression)
```

| parameter | description |
| --- | --- |
| expression | The permission expression to tokenize. |

## Return Value

An enumerable of tokens.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *expression* is `null`. |

## See Also

* class [PermissionExpressionParser](../PermissionExpressionParser.md)