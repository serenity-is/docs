# DateDiffAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

DateDiff expression attribute

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
| [DateDiffAttribute](DateDiffAttribute/DateDiffAttribute.md)(…) | DateDiff expression attribute |
| [End](DateDiffAttribute/End.md) { get; } | Date expression 1 |
| [Part](DateDiffAttribute/Part.md) { get; } | Date part |
| [Start](DateDiffAttribute/Start.md) { get; } | Date expression 1 |
| override [Translate](DateDiffAttribute/Translate.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of expressions is null |

## Remarks

Creates a new instance

## See Also

* class [BaseExpressionAttribute](BaseExpressionAttribute.md)
* **Source:** *[DateDiffAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/DateDiffAttribute.cs)*