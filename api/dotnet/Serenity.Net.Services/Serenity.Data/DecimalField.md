# DecimalField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a Decimal value

```csharp
public sealed class DecimalField : GenericValueField<decimal>
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
| [DecimalField](DecimalField/DecimalField.md)(…) | Field with a Decimal value |
| static [Factory](DecimalField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](DecimalField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](DecimalField/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](DecimalField/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Remarks

Initializes a new instance of the [`DecimalField`](DecimalField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DecimalField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/DecimalField.cs)*