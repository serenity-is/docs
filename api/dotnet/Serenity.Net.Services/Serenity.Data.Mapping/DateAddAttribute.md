# DateAddAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

DateAdd expression attribute, which adds a number of date parts to a date like DATEADD of SQL Server. Adding months or years to the end of a month gives the last day of the target month when it is shorter, e.g. January 31 plus one month is February 28.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class DateAddAttribute : BaseExpressionAttribute
```

| parameter | description |
| --- | --- |
| part | The date part to add, like year or month. |
| number | An expression that returns the number of parts to add, which can be negative. |
| expression | An expression that returns a date value. |

## Public Members

| name | description |
| --- | --- |
| [DateAddAttribute](DateAddAttribute/DateAddAttribute.md)(…) | DateAdd expression attribute, which adds a number of date parts to a date like DATEADD of SQL Server. Adding months or years to the end of a month gives the last day of the target month when it is shorter, e.g. January 31 plus one month is February 28. |
| [Expression](DateAddAttribute/Expression.md) { get; } | Date expression. |
| [Number](DateAddAttribute/Number.md) { get; } | The number of parts to add. |
| [Part](DateAddAttribute/Part.md) { get; } | Date part. |
| override [Translate](DateAddAttribute/Translate.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the expressions is null. |

## See Also

* class [BaseExpressionAttribute](./BaseExpressionAttribute.md)
* **Source:** *[DateAddAttribute.cs](https://github.com/serenity-is/Serenity/blob/01c6c1a2f1de9878f233eb29c6ac73cb685eb01b/src/services/Data/Mapping/DateAddAttribute.cs)*