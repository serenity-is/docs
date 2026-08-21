# PermissionExpressionParser class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Parses and evaluates logical permission expressions containing `!`, `&`, `|`, and parentheses.

```csharp
public static class PermissionExpressionParser
```

## Public Members

| name | description |
| --- | --- |
| static [Evaluate](PermissionExpressionParser/Evaluate.md)(…) | Evaluates tokens in Reverse Polish Notation produced by [`ShuntingYard`](PermissionExpressionParser/ShuntingYard.md). |
| static [ShuntingYard](PermissionExpressionParser/ShuntingYard.md)(…) | Converts tokens to Reverse Polish Notation using the shunting-yard algorithm. |
| static [Tokenize](PermissionExpressionParser/Tokenize.md)(…) | Tokenizes a permission expression into individual operators, parentheses, and permission keys. |

## See Also

* **Source:** *[PermissionExpressionParser.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/PermissionExpressionParser.cs)*