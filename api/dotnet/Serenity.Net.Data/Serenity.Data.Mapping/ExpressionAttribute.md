# ExpressionAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Specifies SQL expression this property corresponds to. You may use brackets ([]) to escape identifiers. Brackets will be converted to database specific quotes.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class ExpressionAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ExpressionAttribute](ExpressionAttribute/ExpressionAttribute.md)(…) | Specifies SQL expression this property corresponds to. (2 constructors) |
| [Dialect](ExpressionAttribute/Dialect.md) { get; set; } | Gets or sets the dialect. |
| [NegateDialect](ExpressionAttribute/NegateDialect.md) { get; set; } | Gets or sets the negating of the dialect. |
| [Value](ExpressionAttribute/Value.md) { get; } | Gets the value. |

## See Also

* **Source:** *[ExpressionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/ExpressionAttribute.cs)*