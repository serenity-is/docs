# DateTimeOffsetField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a DateTimeOffset value

```csharp
public sealed class DateTimeOffsetField : GenericValueField<DateTimeOffset>
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
| [DateTimeOffsetField](DateTimeOffsetField/DateTimeOffsetField.md)(…) | Field with a DateTimeOffset value |
| static [Factory](DateTimeOffsetField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [ConvertValue](DateTimeOffsetField/ConvertValue.md)(…) | Converts the value. |
| override [GetFromReader](DateTimeOffsetField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](DateTimeOffsetField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](DateTimeOffsetField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`DateTimeOffsetField`](DateTimeOffsetField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DateTimeOffsetField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/DateTimeOffsetField.cs)*