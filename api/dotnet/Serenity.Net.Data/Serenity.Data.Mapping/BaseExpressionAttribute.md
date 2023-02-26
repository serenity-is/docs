# BaseExpressionAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Specifies SQL expression this property corresponds to. You may use brackets ([]) to escape identifiers. Brackets will be converted to database specific quotes.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public abstract class BaseExpressionAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [Format](BaseExpressionAttribute/Format.md) { get; set; } | Gets sets an optional format string to apply with {0} placeholder for the expression. |
| [ToString](BaseExpressionAttribute/ToString.md)(…) | Converts the expression to string for specified dialect |
| abstract [Translate](BaseExpressionAttribute/Translate.md)(…) | Gets the expression for specified dialect. Prefer ToString(ISqlDialect) version as it allows the dialect to optionally customize the formatted expression via ISqlExpressionTranslator interface. |
| static [ToString](BaseExpressionAttribute/ToString.md)(…) | Convert the expression to string. Used by derived expression attributes to convert their constructor arguments to string while supporting other expression attribute types, or a special array with the first argument as the attribute type and others as its constructor parameters. |

## Protected Members

| name | description |
| --- | --- |
| [BaseExpressionAttribute](BaseExpressionAttribute/BaseExpressionAttribute.md)() | The default constructor. |

## See Also

* **Source:** *[BaseExpressionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/BaseExpressionAttribute.cs)*