# ReplaceAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Replace expression attribute, which replaces all occurrences of a string in another one like REPLACE of SQL Server.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class ReplaceAttribute : BaseExpressionAttribute
```

| parameter | description |
| --- | --- |
| expression | An expression that returns the string to search in. |
| search | An expression that returns the string to search for. |
| replacement | An expression that returns the string to replace it with. |

## Public Members

| name | description |
| --- | --- |
| [ReplaceAttribute](ReplaceAttribute/ReplaceAttribute.md)(…) | Replace expression attribute, which replaces all occurrences of a string in another one like REPLACE of SQL Server. |
| [Expression](ReplaceAttribute/Expression.md) { get; } | String expression. |
| [Replacement](ReplaceAttribute/Replacement.md) { get; } | Replacement expression. |
| [Search](ReplaceAttribute/Search.md) { get; } | Search expression. |
| override [Translate](ReplaceAttribute/Translate.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the expressions is null. |

## See Also

* class [BaseExpressionAttribute](./BaseExpressionAttribute.md)
* **Source:** *[ReplaceAttribute.cs](https://github.com/serenity-is/Serenity/blob/b3dd582d5e3c463e59a4dcee62b7c96f3610b91d/src/services/Data/Mapping/ReplaceAttribute.cs)*