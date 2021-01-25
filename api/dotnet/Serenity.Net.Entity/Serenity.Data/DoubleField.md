# DoubleField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a Double value

```csharp
public sealed class DoubleField : GenericValueField<double>
```

## Public Members

| name | description |
| --- | --- |
| [DoubleField](DoubleField/DoubleField.md)(…) | Initializes a new instance of the [`DoubleField`](DoubleField.md) class. |
| static [Factory](DoubleField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](DoubleField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](DoubleField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](DoubleField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[DoubleField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/DoubleField.cs)*