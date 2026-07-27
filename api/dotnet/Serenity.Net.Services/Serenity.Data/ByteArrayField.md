# ByteArrayField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a byte[] value

```csharp
public class ByteArrayField : CustomClassField<byte[]>
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
| [ByteArrayField](ByteArrayField/ByteArrayField.md)(…) | Field with a byte[] value |
| static [Factory](ByteArrayField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [AsSqlValue](ByteArrayField/AsSqlValue.md)(…) |  |
| override [GetFromReader](ByteArrayField/GetFromReader.md)(…) | Gets field value from a reader. |
| override [ValueFromJson](ByteArrayField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](ByteArrayField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Protected Members

| name | description |
| --- | --- |
| override [Clone](ByteArrayField/Clone.md)(…) | Clones the specified value. |
| override [CompareValues](ByteArrayField/CompareValues.md)(…) | Compares the values. |

## Remarks

Initializes a new instance of the [`ByteArrayField`](ByteArrayField.md) class.

## See Also

* class [CustomClassField&lt;TValue&gt;](CustomClassField-1.md)
* **Source:** *[ByteArrayField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/ByteArrayField.cs)*