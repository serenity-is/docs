# DecimalField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a Decimal value

```csharp
public sealed class DecimalField : GenericValueField<decimal>
```

## Public Members

| name | description |
| --- | --- |
| [DecimalField](DecimalField/DecimalField.md)(…) | Initializes a new instance of the [`DecimalField`](DecimalField.md) class. |
| static [Factory](DecimalField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](DecimalField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](DecimalField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](DecimalField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DecimalField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/DecimalField.cs)*