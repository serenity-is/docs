# PermissionExpressionParser.ShuntingYard method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts a list of tokens to Reverse Polish Notation using ShuntingYard algorithm.

```csharp
public static IEnumerable<string> ShuntingYard(IEnumerable<string> tokens)
```

| parameter | description |
| --- | --- |
| tokens | List of tokens, produced from Tokenize method |

## Return Value

Tokens in RPN notation

## See Also

* class [PermissionExpressionParser](../PermissionExpressionParser.md)