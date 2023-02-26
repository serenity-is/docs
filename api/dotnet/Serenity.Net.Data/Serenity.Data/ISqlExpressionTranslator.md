# ISqlExpressionTranslator interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

An interface custom ISqlDialect types can implement to change generated expressions for dynamic expression like ConcatExpressionAttribute. They should return NULL if it can't handle this expression type

```csharp
public interface ISqlExpressionTranslator
```

## Members

| name | description |
| --- | --- |
| [Translate](ISqlExpressionTranslator/Translate.md)(…) | Returns customized version for passed expression attribute. If the dialect don't have custom handling for the expression, it should return null. |

## See Also

* **Source:** *[ISqlExpressionTranslator.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/ISqlExpressionTranslator.cs)*