# DateTimeOffsetField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a DateTimeOffset value

```csharp
public sealed class DateTimeOffsetField : GenericValueField<DateTimeOffset>
```

## Public Members

| name | description |
| --- | --- |
| [DateTimeOffsetField](DateTimeOffsetField/DateTimeOffsetField.md)(…) | Initializes a new instance of the [`DateTimeOffsetField`](DateTimeOffsetField.md) class. |
| static [Factory](DateTimeOffsetField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| [Item](DateTimeOffsetField/Item.md) { get; set; } | Gets or sets the value of this field with the specified row. |
| override [AsObject](DateTimeOffsetField/AsObject.md)(…) | Gets the value of this field in specified row as object. (2 methods) |
| override [GetFromReader](DateTimeOffsetField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](DateTimeOffsetField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](DateTimeOffsetField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DateTimeOffsetField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/DateTimeOffsetField.cs)*