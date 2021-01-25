# ByteArrayField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a byte[] value

```csharp
public class ByteArrayField : CustomClassField<byte[]>
```

## Public Members

| name | description |
| --- | --- |
| [ByteArrayField](ByteArrayField/ByteArrayField.md)(…) | Initializes a new instance of the [`ByteArrayField`](ByteArrayField.md) class. |
| static [Factory](ByteArrayField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](ByteArrayField/GetFromReader.md)(…) | Gets field value from a reader. |
| override [ValueFromJson](ByteArrayField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](ByteArrayField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## Protected Members

| name | description |
| --- | --- |
| override [Clone](ByteArrayField/Clone.md)(…) | Clones the specified value. |
| override [CompareValues](ByteArrayField/CompareValues.md)(…) | Compares the values. |

## See Also

* class [CustomClassField&lt;TValue&gt;](CustomClassField-1.md)
* **Source:** *[ByteArrayField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/ByteArrayField.cs)*