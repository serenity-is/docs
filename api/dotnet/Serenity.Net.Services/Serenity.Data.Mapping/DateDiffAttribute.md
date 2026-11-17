# DateDiffAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

DateDiff expression attribute, which returns the number of date part boundaries crossed between two dates like DATEDIFF of SQL Server, e.g. one day from 23:00 to 01:00 of the next day, and one year from December 31 to January 1, rather than the number of complete units between them.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class DateDiffAttribute : BaseExpressionAttribute
```

| parameter | description |
| --- | --- |
| part | Datepart like "year", "month" etc. |
| start | An expression that returns a date value |
| end | An expression that returns a date value |

## Public Members

| name | description |
| --- | --- |
| [DateDiffAttribute](DateDiffAttribute/DateDiffAttribute.md)(…) | DateDiff expression attribute, which returns the number of date part boundaries crossed between two dates like DATEDIFF of SQL Server, e.g. one day from 23:00 to 01:00 of the next day, and one year from December 31 to January 1, rather than the number of complete units between them. |
| [End](DateDiffAttribute/End.md) { get; } | Date expression 2. |
| [Part](DateDiffAttribute/Part.md) { get; } | Date part. |
| [Start](DateDiffAttribute/Start.md) { get; } | Date expression 1. |
| override [Translate](DateDiffAttribute/Translate.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of expressions is null |

## Remarks

Creates a new instance

## See Also

* class [BaseExpressionAttribute](./BaseExpressionAttribute.md)
* **Source:** *[DateDiffAttribute.cs](https://github.com/serenity-is/Serenity/blob/01c6c1a2f1de9878f233eb29c6ac73cb685eb01b/src/services/Data/Mapping/DateDiffAttribute.cs)*