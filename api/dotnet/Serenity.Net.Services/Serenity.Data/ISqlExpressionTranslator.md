# ISqlExpressionTranslator interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An interface that custom [`ISqlDialect`](ISqlDialect.md) types can implement to change the generated expressions for dynamic expressions like `ConcatExpressionAttribute`. Implementors should return `null` if they cannot handle the given expression type.

```csharp
public interface ISqlExpressionTranslator
```

## Members

| name | description |
| --- | --- |
| [Translate](ISqlExpressionTranslator/Translate.md)(…) | Returns a customized version for the passed expression attribute. If the dialect has no custom handling for the expression, it should return `null`. |

## See Also

* **Source:** *[ISqlExpressionTranslator.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Dialects/ISqlExpressionTranslator.cs)*