# JsonField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with JSON value

```csharp
public class JsonField<TValue> : GenericClassField<TValue>
    where TValue : class
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |

## Public Members

| name | description |
| --- | --- |
| [JsonField](JsonField-1/JsonField.md)(…) | Initializes a new instance of the [`JsonField`](JsonField-1.md) class. |
| static [Factory](JsonField-1/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| [Settings](JsonField-1/Settings.md) { get; set; } | Gets or sets the settings. |
| override [AsSqlValue](JsonField-1/AsSqlValue.md)(…) | Gets the value of this row as an SQL value. |
| override [GetFromReader](JsonField-1/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](JsonField-1/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](JsonField-1/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](JsonField-1/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* class [TValue](../Serenity.Net.Entity/JsonField-1.TValue.md)
* **Source:** *[JsonField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/JsonField.cs)*