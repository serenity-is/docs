# Int32Field class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with Int32 value

```csharp
public class Int32Field : GenericValueField<int>
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
| [Int32Field](Int32Field/Int32Field.md)(…) | Field with Int32 value |
| static [Factory](Int32Field/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](Int32Field/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](Int32Field/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](Int32Field/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`Int32Field`](Int32Field.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[Int32Field.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/Int32Field.cs)*