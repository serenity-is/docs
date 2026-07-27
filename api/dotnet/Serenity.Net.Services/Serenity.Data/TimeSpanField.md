# TimeSpanField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a TimeSpan value

```csharp
public sealed class TimeSpanField : GenericValueField<TimeSpan>
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
| [TimeSpanField](TimeSpanField/TimeSpanField.md)(…) | Field with a TimeSpan value |
| static [Factory](TimeSpanField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](TimeSpanField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](TimeSpanField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](TimeSpanField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`TimeSpanField`](TimeSpanField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[TimeSpanField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/TimeSpanField.cs)*