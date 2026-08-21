# PermissionExpressionParser.ShuntingYard method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts tokens to Reverse Polish Notation using the shunting-yard algorithm.

```csharp
public static IEnumerable<string> ShuntingYard(IEnumerable<string> tokens)
```

| parameter | description |
| --- | --- |
| tokens | The tokens produced by [`Tokenize`](Tokenize.md). |

## Return Value

Tokens in Reverse Polish Notation.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *tokens* is `null`. |
| InvalidOperationException | The expression contains mismatched parentheses. |

## See Also

* class [PermissionExpressionParser](../PermissionExpressionParser.md)