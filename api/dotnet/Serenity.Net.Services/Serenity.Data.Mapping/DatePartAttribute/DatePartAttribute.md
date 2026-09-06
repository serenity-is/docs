# DatePartAttribute constructor

DatePart expression attribute

```csharp
public DatePartAttribute(DateParts part, object expression)
```

| parameter | description |
| --- | --- |
| expression | An expression that returns a date value |
| part | Datepart like "year", "month" etc. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of expressions is null |

## Remarks

Creates a new instance

## See Also

* enum [DateParts](../../Serenity.Data/DateParts.md)
* class [DatePartAttribute](../DatePartAttribute.md)