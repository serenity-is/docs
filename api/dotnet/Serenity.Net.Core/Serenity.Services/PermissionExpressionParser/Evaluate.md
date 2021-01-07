# PermissionExpressionParser.Evaluate method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Evaluates a list of tokens in RPN notation, produced from ShuntingYard method.

```csharp
public static bool Evaluate(IEnumerable<string> rpnTokens, Func<string, bool> hasPermission)
```

| parameter | description |
| --- | --- |
| rpnTokens | List of tokens in RPN notation |
| hasPermission | A method that returns True if the user has given permission |

## Return Value

True if expression evaluates to true

## See Also

* class [PermissionExpressionParser](../PermissionExpressionParser.md)