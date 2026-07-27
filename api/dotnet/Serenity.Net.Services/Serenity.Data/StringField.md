# StringField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a String value

```csharp
public class StringField : GenericClassField<string>
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
| [StringField](StringField/StringField.md)(…) | Field with a String value |
| static [Factory](StringField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](StringField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](StringField/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](StringField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](StringField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`StringField`](StringField.md) class.

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* **Source:** *[StringField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/StringField.cs)*