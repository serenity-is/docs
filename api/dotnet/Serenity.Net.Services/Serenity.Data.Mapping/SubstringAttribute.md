# SubstringAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Substring expression attribute, which returns a part of a string like SUBSTRING of SQL Server.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class SubstringAttribute : BaseExpressionAttribute
```

| parameter | description |
| --- | --- |
| expression | An expression that returns a string. |
| start | An expression that returns the position of the first character, starting from 1. |
| length | An expression that returns the number of characters. |

## Public Members

| name | description |
| --- | --- |
| [SubstringAttribute](SubstringAttribute/SubstringAttribute.md)(…) | Substring expression attribute, which returns a part of a string like SUBSTRING of SQL Server. |
| [Expression](SubstringAttribute/Expression.md) { get; } | String expression. |
| [Length](SubstringAttribute/Length.md) { get; } | Length expression. |
| [Start](SubstringAttribute/Start.md) { get; } | Start position expression. |
| override [Translate](SubstringAttribute/Translate.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the expressions is null. |

## See Also

* class [BaseExpressionAttribute](./BaseExpressionAttribute.md)
* **Source:** *[SubstringAttribute.cs](https://github.com/serenity-is/Serenity/blob/b3dd582d5e3c463e59a4dcee62b7c96f3610b91d/src/services/Data/Mapping/SubstringAttribute.cs)*