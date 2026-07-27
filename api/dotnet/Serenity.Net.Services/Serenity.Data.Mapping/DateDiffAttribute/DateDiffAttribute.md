# DateDiffAttribute constructor
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

DateDiff expression attribute

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