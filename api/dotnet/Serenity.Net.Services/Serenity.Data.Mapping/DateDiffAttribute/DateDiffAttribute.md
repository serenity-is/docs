# DateDiffAttribute constructor

DateDiff expression attribute, which returns the number of date part boundaries crossed between two dates like DATEDIFF of SQL Server, e.g. one day from 23:00 to 01:00 of the next day, and one year from December 31 to January 1, rather than the number of complete units between them.

```csharp
public DateDiffAttribute(DateParts part, object start, object end)
```

| parameter | description |
| --- | --- |
| part | Datepart like "year", "month" etc. |
| start | An expression that returns a date value |
| end | An expression that returns a date value |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of expressions is null |

## Remarks

Creates a new instance

## See Also

* enum [DateParts](../../Serenity.Data/DateParts.md)
* class [DateDiffAttribute](../DateDiffAttribute.md)