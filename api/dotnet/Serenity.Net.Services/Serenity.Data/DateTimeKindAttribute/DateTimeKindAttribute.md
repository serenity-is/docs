# DateTimeKindAttribute constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Determines Time kind for a DateTime field.

```csharp
public DateTimeKindAttribute(DateTimeKind value)
```

| parameter | description |
| --- | --- |
| value | The value. If Unspecified, it means this is a DateTime field but no time zone conversions should be done. Local means dates should be converted to server local time. Utc means dates should be converted to UTC timezone. |

## Remarks

Initializes a new instance of the [`DateTimeKindAttribute`](../DateTimeKindAttribute.md) class.

## See Also

* class [DateTimeKindAttribute](../DateTimeKindAttribute.md)