# CastAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Cast expression attribute, which converts a value to one of the types that have an equivalent in all supported databases: Int32, Int64, Decimal with [`Precision`](./CastAttribute/Precision.md) and [`Scale`](./CastAttribute/Scale.md), String with [`Size`](./CastAttribute/Size.md), and Date, which drops the time. Converting a number with a fraction to an integer truncates it in SQL Server and SQLite, while it rounds it in the others. SQLite has no decimal type, so a decimal is a REAL there.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class CastAttribute : BaseExpressionAttribute
```

| parameter | description |
| --- | --- |
| expression | An expression that returns the value to convert. |
| type | The type to convert to. |

## Public Members

| name | description |
| --- | --- |
| [CastAttribute](CastAttribute/CastAttribute.md)(…) | Cast expression attribute, which converts a value to one of the types that have an equivalent in all supported databases: Int32, Int64, Decimal with [`Precision`](./CastAttribute/Precision.md) and [`Scale`](./CastAttribute/Scale.md), String with [`Size`](./CastAttribute/Size.md), and Date, which drops the time. Converting a number with a fraction to an integer truncates it in SQL Server and SQLite, while it rounds it in the others. SQLite has no decimal type, so a decimal is a REAL there. |
| [Expression](CastAttribute/Expression.md) { get; } | The expression to convert. |
| [Precision](CastAttribute/Precision.md) { get; set; } | The number of digits for Decimal, 18 by default. |
| [Scale](CastAttribute/Scale.md) { get; set; } | The number of digits after the decimal point for Decimal, 2 by default. |
| [Size](CastAttribute/Size.md) { get; set; } | The number of characters for String, 255 by default. |
| [Type](CastAttribute/Type.md) { get; } | The type to convert to. |
| override [Translate](CastAttribute/Translate.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | The expression is null. |

## See Also

* class [BaseExpressionAttribute](./BaseExpressionAttribute.md)
* **Source:** *[CastAttribute.cs](https://github.com/serenity-is/Serenity/blob/b3dd582d5e3c463e59a4dcee62b7c96f3610b91d/src/services/Data/Mapping/CastAttribute.cs)*