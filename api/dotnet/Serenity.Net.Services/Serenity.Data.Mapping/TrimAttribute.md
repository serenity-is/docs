# TrimAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Trim expression attribute, which removes the spaces at the start, at the end, or both, of a string, like TRIM, LTRIM and RTRIM of SQL Server.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class TrimAttribute : BaseExpressionAttribute
```

| parameter | description |
| --- | --- |
| expression | An expression that returns a string. |

## Public Members

| name | description |
| --- | --- |
| [TrimAttribute](TrimAttribute/TrimAttribute.md)(…) | Trim expression attribute, which removes the spaces at the start, at the end, or both, of a string, like TRIM, LTRIM and RTRIM of SQL Server. |
| [Expression](TrimAttribute/Expression.md) { get; } | String expression. |
| [Leading](TrimAttribute/Leading.md) { get; set; } | Whether to remove the spaces at the start, true by default. |
| [Trailing](TrimAttribute/Trailing.md) { get; set; } | Whether to remove the spaces at the end, true by default. |
| override [Translate](TrimAttribute/Translate.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | The expression is null. |

## See Also

* class [BaseExpressionAttribute](./BaseExpressionAttribute.md)
* **Source:** *[TrimAttribute.cs](https://github.com/serenity-is/Serenity/blob/eaaebc4b685161ea47e51b8979fe43bce614b5aa/src/services/Data/Mapping/TrimAttribute.cs)*