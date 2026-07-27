# GuidField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a Guid value

```csharp
public sealed class GuidField : GenericValueField<Guid>
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
| [GuidField](GuidField/GuidField.md)(…) | Field with a Guid value |
| static [Factory](GuidField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [ConvertValue](GuidField/ConvertValue.md)(…) | Converts the value. |
| override [GetFromReader](GuidField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](GuidField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](GuidField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`GuidField`](GuidField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[GuidField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/GuidField.cs)*