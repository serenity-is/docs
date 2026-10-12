# StringField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a String value.

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
| [StringField](StringField/StringField.md)(…) | Field with a String value. |
| static [Factory](StringField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](StringField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](StringField/ValueFromJson.md)(…) | Deserializes this field's value from JSON. (2 methods) |
| override [ValueToJson](StringField/ValueToJson.md)(…) | Serializes this field's value to JSON. (2 methods) |

## Remarks

Initializes a new instance of the [`StringField`](./StringField.md) class.

## See Also

* class [GenericClassField&lt;TValue&gt;](./GenericClassField-1.md)
* **Source:** *[StringField.cs](https://github.com/serenity-is/Serenity/blob/2de63af061ea10761df9dab64bc27e8de387af4a/src/services/Entity/FieldTypes/StringField.cs)*