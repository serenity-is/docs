# DateDiffAttribute constructor
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new instance

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

## See Also

* enum [DateParts](../../Serenity.Data/DateParts.md)
* class [DateDiffAttribute](../DateDiffAttribute.md)