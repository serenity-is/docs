# StreamField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a Stream value

```csharp
public class StreamField : GenericClassField<Stream>
```

## Public Members

| name | description |
| --- | --- |
| [StreamField](StreamField/StreamField.md)(…) | Initializes a new instance of the [`StreamField`](StreamField.md) class. |
| static [Factory](StreamField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](StreamField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](StreamField/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](StreamField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](StreamField/ValueToJson.md)(…) | Serializes this fields value to JSON |
| static [CopyStream](StreamField/CopyStream.md)(…) | Copies the stream. |

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* **Source:** *[StreamField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/StreamField.cs)*