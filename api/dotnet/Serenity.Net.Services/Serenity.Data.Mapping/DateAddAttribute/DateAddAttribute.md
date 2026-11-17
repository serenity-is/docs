# DateAddAttribute constructor

DateAdd expression attribute, which adds a number of date parts to a date like DATEADD of SQL Server. Adding months or years to the end of a month gives the last day of the target month when it is shorter, e.g. January 31 plus one month is February 28.

```csharp
public DateAddAttribute(DateParts part, object number, object expression)
```

| parameter | description |
| --- | --- |
| part | The date part to add, like year or month. |
| number | An expression that returns the number of parts to add, which can be negative. |
| expression | An expression that returns a date value. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the expressions is null. |

## See Also

* enum [DateParts](../../Serenity.Data/DateParts.md)
* class [DateAddAttribute](../DateAddAttribute.md)