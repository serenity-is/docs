# Int64Field class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with Int64 value

```csharp
public sealed class Int64Field : GenericValueField<long>
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
| [Int64Field](Int64Field/Int64Field.md)(…) | Field with Int64 value |
| static [Factory](Int64Field/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](Int64Field/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](Int64Field/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](Int64Field/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`Int64Field`](Int64Field.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[Int64Field.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/Int64Field.cs)*