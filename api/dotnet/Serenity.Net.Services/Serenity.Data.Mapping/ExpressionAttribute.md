# ExpressionAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Specifies SQL expression this property corresponds to. You may use brackets ([]) to escape identifiers. Brackets will be converted to database specific quotes.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class ExpressionAttribute : BaseExpressionAttribute
```

| parameter | description |
| --- | --- |
| value | An SQL expression like (T0.Firstname + ' ' + T0.LastName) |

## Public Members

| name | description |
| --- | --- |
| [ExpressionAttribute](ExpressionAttribute/ExpressionAttribute.md)(…) | Specifies SQL expression this property corresponds to. You may use brackets ([]) to escape identifiers. Brackets will be converted to database specific quotes. (2 constructors) |
| [Dialect](ExpressionAttribute/Dialect.md) { get; set; } | Gets or sets the dialect. |
| [NegateDialect](ExpressionAttribute/NegateDialect.md) { get; set; } | Gets or sets the negating of the dialect. |
| [Value](ExpressionAttribute/Value.md) { get; } | Gets the expression. |
| override [Translate](ExpressionAttribute/Translate.md)(…) |  |

## Remarks

Specifies SQL expression this property corresponds to. Multiple attributes are allowed for dialect-specific variants. Resolution needs no declaration ordering: DialectExpressionSelector.GetBestMatch picks the most specific matching dialect, and throws AmbiguousMatchException when two attributes match the same dialect.

## See Also

* class [BaseExpressionAttribute](./BaseExpressionAttribute.md)
* **Source:** *[ExpressionAttribute.cs](https://github.com/serenity-is/Serenity/blob/8a3cd8708f6a88765518ce8c4a2afe7ed0ce54f3/src/services/Data/Mapping/ExpressionAttribute.cs)*