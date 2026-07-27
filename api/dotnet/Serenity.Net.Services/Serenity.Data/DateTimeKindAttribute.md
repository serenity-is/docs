# DateTimeKindAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Determines Time kind for a DateTime field.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class DateTimeKindAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | The value. If Unspecified, it means this is a DateTime field but no time zone conversions should be done. Local means dates should be converted to server local time. Utc means dates should be converted to UTC timezone. |

## Public Members

| name | description |
| --- | --- |
| [DateTimeKindAttribute](DateTimeKindAttribute/DateTimeKindAttribute.md)(…) | Determines Time kind for a DateTime field. |
| [Value](DateTimeKindAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`DateTimeKindAttribute`](DateTimeKindAttribute.md) class.

## See Also

* **Source:** *[DateTimeKindAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/DateTimeKindAttribute.cs)*