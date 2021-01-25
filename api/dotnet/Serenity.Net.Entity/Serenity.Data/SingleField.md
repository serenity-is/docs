# SingleField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a Single value

```csharp
public sealed class SingleField : GenericValueField<float>
```

## Public Members

| name | description |
| --- | --- |
| [SingleField](SingleField/SingleField.md)(…) | Initializes a new instance of the [`SingleField`](SingleField.md) class. |
| static [Factory](SingleField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](SingleField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](SingleField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](SingleField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[SingleField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/SingleField.cs)*