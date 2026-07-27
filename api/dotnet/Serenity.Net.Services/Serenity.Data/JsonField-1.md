# JsonField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with JSON value

```csharp
public class JsonField<TValue> : GenericClassField<TValue>
    where TValue : class
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |
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
| [JsonField](JsonField-1/JsonField.md)(…) | Field with JSON value |
| static [Factory](JsonField-1/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| [SerializerOptions](JsonField-1/SerializerOptions.md) { get; set; } | Gets or sets the settings. |
| override [AsSqlValue](JsonField-1/AsSqlValue.md)(…) | Gets the value of this row as an SQL value. |
| override [GetFromReader](JsonField-1/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](JsonField-1/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](JsonField-1/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](JsonField-1/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`JsonField`](JsonField-1.md) class.

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* class [TValue](../Serenity.Net.Services/JsonField-1.TValue.md)
* **Source:** *[JsonField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/JsonField.cs)*