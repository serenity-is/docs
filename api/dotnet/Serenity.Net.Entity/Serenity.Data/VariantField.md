# VariantField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a Variant (e.g. SQL VARIANT) value

```csharp
public class VariantField : GenericClassField<object>
```

## Public Members

| name | description |
| --- | --- |
| [VariantField](VariantField/VariantField.md)(…) | Initializes a new instance of the [`VariantField`](VariantField.md) class. |
| static [Factory](VariantField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](VariantField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](VariantField/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](VariantField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](VariantField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* **Source:** *[VariantField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/VariantField.cs)*