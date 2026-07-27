# Int16Field class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with Int16 value

```csharp
public sealed class Int16Field : GenericValueField<short>
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
| [Int16Field](Int16Field/Int16Field.md)(…) | Field with Int16 value |
| static [Factory](Int16Field/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](Int16Field/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](Int16Field/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](Int16Field/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`Int16Field`](Int16Field.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[Int16Field.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/Int16Field.cs)*