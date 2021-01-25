# StringField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a String value

```csharp
public class StringField : GenericClassField<string>
```

## Public Members

| name | description |
| --- | --- |
| [StringField](StringField/StringField.md)(…) | Initializes a new instance of the [`StringField`](StringField.md) class. |
| static [Factory](StringField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](StringField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](StringField/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](StringField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](StringField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* **Source:** *[StringField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/StringField.cs)*