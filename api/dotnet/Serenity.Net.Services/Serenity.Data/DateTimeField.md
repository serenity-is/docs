# DateTimeField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a DateTime value

```csharp
public sealed class DateTimeField : GenericValueField<DateTime>
```

| parameter | description |
| --- | --- |
| collection | The collection. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Public Members

| name | description |
| --- | --- |
| [DateTimeField](DateTimeField/DateTimeField.md)(…) | Field with a DateTime value |
| static [Factory](DateTimeField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| [DateOnly](DateTimeField/DateOnly.md) { get; set; } | Gets or sets a value indicating whether the field is date only, e.g. no time part. |
| [DateTimeKind](DateTimeField/DateTimeKind.md) { get; set; } | Gets or sets the kind of the date time. Unspecified means no date/time conversions, Local means local time zone, Utc means UTC time zone |
| [Item](DateTimeField/Item.md) { get; set; } | Gets or sets the value of this field with the specified row. |
| override [AsObject](DateTimeField/AsObject.md)(…) | Sets the value of this field in specified row as object. |
| override [ConvertValue](DateTimeField/ConvertValue.md)(…) | Converts the value. |
| override [GetFromReader](DateTimeField/GetFromReader.md)(…) | Gets field value from a data reader. |
| [ToDateTimeKind](DateTimeField/ToDateTimeKind.md)(…) | Converts the value to this field's DateTimeKind (2 methods) |
| override [ValueFromJson](DateTimeField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](DateTimeField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |
| static [ToDateTimeKind](DateTimeField/ToDateTimeKind.md)(…) | Converts the value to specified DateTimeKind (2 methods) |

## Remarks

Initializes a new instance of the [`DateTimeField`](DateTimeField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DateTimeField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/DateTimeField.cs)*