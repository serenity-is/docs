# PermissionExpressionParser class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A simple parser / evaluator for logic permission expressions

```csharp
public static class PermissionExpressionParser
```

## Public Members

| name | description |
| --- | --- |
| static [Evaluate](PermissionExpressionParser/Evaluate.md)(…) | Evaluates a list of tokens in RPN notation, produced from ShuntingYard method. |
| static [ShuntingYard](PermissionExpressionParser/ShuntingYard.md)(…) | Converts a list of tokens to Reverse Polish Notation using ShuntingYard algorithm. |
| static [Tokenize](PermissionExpressionParser/Tokenize.md)(…) | Tokenizes a permission expression |

## See Also

* **Source:** *[PermissionExpressionParser.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/PermissionExpressionParser.cs)*