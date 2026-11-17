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

## Protected Members

| name | description |
| --- | --- |
| virtual [ConvertJsonValue](StringField/ConvertJsonValue.md)(…) | Converts or validates a non-null string value read from JSON before it is set on the row. It is not called for a JSON null. Derived fields can override it to reject a value by throwing, in which case the row is left unassigned for this field. |

## Remarks

Initializes a new instance of the [`StringField`](./StringField.md) class.

## See Also

* class [GenericClassField&lt;TValue&gt;](./GenericClassField-1.md)
* **Source:** *[StringField.cs](https://github.com/serenity-is/Serenity/blob/a75b99310ca194a360f1da1b131f539fd279c957/src/services/Entity/FieldTypes/StringField.cs)*