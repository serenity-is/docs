# SingleField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a Single value

```csharp
public sealed class SingleField : GenericValueField<float>
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
| [SingleField](SingleField/SingleField.md)(…) | Field with a Single value |
| static [Factory](SingleField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](SingleField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](SingleField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](SingleField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`SingleField`](SingleField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[SingleField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/SingleField.cs)*