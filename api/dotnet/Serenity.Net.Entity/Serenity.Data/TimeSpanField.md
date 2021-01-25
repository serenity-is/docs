# TimeSpanField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a TimeSpan value

```csharp
public sealed class TimeSpanField : GenericValueField<TimeSpan>
```

## Public Members

| name | description |
| --- | --- |
| [TimeSpanField](TimeSpanField/TimeSpanField.md)(…) | Initializes a new instance of the [`TimeSpanField`](TimeSpanField.md) class. |
| static [Factory](TimeSpanField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| [Item](TimeSpanField/Item.md) { get; set; } | Gets or sets the Nullable with the specified row. |
| override [AsObject](TimeSpanField/AsObject.md)(…) | Gets the value of this field in specified row as object. (2 methods) |
| override [GetFromReader](TimeSpanField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](TimeSpanField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](TimeSpanField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[TimeSpanField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/TimeSpanField.cs)*