# VariantField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a Variant (e.g. SQL VARIANT) value.

```csharp
public class VariantField : GenericClassField<object>
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
| [VariantField](VariantField/VariantField.md)(…) | Field with a Variant (e.g. SQL VARIANT) value. |
| static [Factory](VariantField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](VariantField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](VariantField/ValueFromJson.md)(…) | Deserializes this field's value from JSON. (2 methods) |
| override [ValueToJson](VariantField/ValueToJson.md)(…) | Serializes this field's value to JSON. (2 methods) |

## Protected Members

| name | description |
| --- | --- |
| override [CompareValues](VariantField/CompareValues.md)(…) | Compares two values of this field using the specified comparer. |

## Remarks

Initializes a new instance of the [`VariantField`](./VariantField.md) class.

## See Also

* class [GenericClassField&lt;TValue&gt;](./GenericClassField-1.md)
* **Source:** *[VariantField.cs](https://github.com/serenity-is/Serenity/blob/f828b609b385564332aeeec6f0d6a031cde4142f/src/services/Entity/FieldTypes/VariantField.cs)*