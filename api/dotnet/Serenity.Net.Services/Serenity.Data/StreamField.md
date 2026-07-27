# StreamField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a Stream value

```csharp
public class StreamField : GenericClassField<Stream>
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
| [StreamField](StreamField/StreamField.md)(…) | Field with a Stream value |
| static [Factory](StreamField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [AsSqlValue](StreamField/AsSqlValue.md)(…) |  |
| override [GetFromReader](StreamField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](StreamField/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](StreamField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](StreamField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |
| static [CopyStream](StreamField/CopyStream.md)(…) | Copies the stream. |

## Remarks

Initializes a new instance of the [`StreamField`](StreamField.md) class.

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* **Source:** *[StreamField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/StreamField.cs)*