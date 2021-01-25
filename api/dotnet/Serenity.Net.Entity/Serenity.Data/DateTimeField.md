# DateTimeField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a DateTime value

```csharp
public sealed class DateTimeField : GenericValueField<DateTime>
```

## Public Members

| name | description |
| --- | --- |
| [DateTimeField](DateTimeField/DateTimeField.md)(…) | Initializes a new instance of the [`DateTimeField`](DateTimeField.md) class. |
| static [Factory](DateTimeField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| [DateOnly](DateTimeField/DateOnly.md) { get; set; } | Gets or sets a value indicating whether the field is date only, e.g. no time part. |
| [DateTimeKind](DateTimeField/DateTimeKind.md) { get; set; } | Gets or sets the kind of the date time. Unspecified means no date/time conversions, Local means local time zone, Utc means UTC time zone |
| [Item](DateTimeField/Item.md) { get; set; } | Gets or sets the value of this field with the specified row. |
| override [AsObject](DateTimeField/AsObject.md)(…) | Gets the value of this field in specified row as object. (2 methods) |
| override [ConvertValue](DateTimeField/ConvertValue.md)(…) | Converts the value. |
| override [GetFromReader](DateTimeField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](DateTimeField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](DateTimeField/ValueToJson.md)(…) | Serializes this fields value to JSON |
| static [ToDateTimeKind](DateTimeField/ToDateTimeKind.md)(…) | Converts the value to specified DateTimeKind (2 methods) |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DateTimeField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/DateTimeField.cs)*