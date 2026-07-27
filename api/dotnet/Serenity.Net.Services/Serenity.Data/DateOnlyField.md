# DateOnlyField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a DateOnly value

```csharp
public sealed class DateOnlyField : GenericValueField<DateOnly>
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
| [DateOnlyField](DateOnlyField/DateOnlyField.md)(…) | Field with a DateOnly value |
| static [Factory](DateOnlyField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [AsObject](DateOnlyField/AsObject.md)(…) | Sets the value of this field in specified row as object. |
| override [ConvertValue](DateOnlyField/ConvertValue.md)(…) | Converts the value. |
| override [GetFromReader](DateOnlyField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](DateOnlyField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](DateOnlyField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`DateOnlyField`](DateOnlyField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DateOnlyField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/DateOnlyField.cs)*