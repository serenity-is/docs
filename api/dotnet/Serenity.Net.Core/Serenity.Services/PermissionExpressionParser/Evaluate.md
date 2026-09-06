# PermissionExpressionParser.Evaluate method

Evaluates tokens in Reverse Polish Notation produced by [`ShuntingYard`](./ShuntingYard.md).

```csharp
public static bool Evaluate(IEnumerable<string> rpnTokens, Func<string, bool> hasPermission)
```

| parameter | description |
| --- | --- |
| rpnTokens | The tokens in Reverse Polish Notation. |
| hasPermission | A function that returns `true` if the user has the specified permission key. |

## Return Value

`true` if the expression evaluates to granted; otherwise `false`.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *rpnTokens* or *hasPermission* is `null`. |
| InvalidOperationException | The expression is malformed and cannot be evaluated. |

## See Also

* class [PermissionExpressionParser](../PermissionExpressionParser.md)