# DoubleField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a Double value

```csharp
public sealed class DoubleField : GenericValueField<double>
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
| [DoubleField](DoubleField/DoubleField.md)(…) | Field with a Double value |
| static [Factory](DoubleField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](DoubleField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](DoubleField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](DoubleField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`DoubleField`](DoubleField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DoubleField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/DoubleField.cs)*