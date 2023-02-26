# BaseExpressionAttribute.Translate method
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets the expression for specified dialect. Prefer ToString(ISqlDialect) version as it allows the dialect to optionally customize the formatted expression via ISqlExpressionTranslator interface.

```csharp
public abstract string Translate(ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| dialect | Target dialect |

## See Also

* interface [ISqlDialect](../../Serenity.Data/ISqlDialect.md)
* class [BaseExpressionAttribute](../BaseExpressionAttribute.md)