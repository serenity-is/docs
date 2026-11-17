# DatePartAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

DatePart expression attribute

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class DatePartAttribute : BaseExpressionAttribute
```

| parameter | description |
| --- | --- |
| expression | An expression that returns a date value |
| part | Datepart like "year", "month" etc. |

## Public Members

| name | description |
| --- | --- |
| [DatePartAttribute](DatePartAttribute/DatePartAttribute.md)(…) | DatePart expression attribute |
| [Expression](DatePartAttribute/Expression.md) { get; } | Date expression. |
| [Part](DatePartAttribute/Part.md) { get; } | Date part. |
| override [Translate](DatePartAttribute/Translate.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of expressions is null |

## Remarks

Creates a new instance

## See Also

* class [BaseExpressionAttribute](./BaseExpressionAttribute.md)
* **Source:** *[DatePartAttribute.cs](https://github.com/serenity-is/Serenity/blob/01c6c1a2f1de9878f233eb29c6ac73cb685eb01b/src/services/Data/Mapping/DatePartAttribute.cs)*