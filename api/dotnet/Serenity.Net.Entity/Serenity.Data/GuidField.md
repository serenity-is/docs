# GuidField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a Guid value

```csharp
public sealed class GuidField : GenericValueField<Guid>
```

## Public Members

| name | description |
| --- | --- |
| [GuidField](GuidField/GuidField.md)(…) | Initializes a new instance of the [`GuidField`](GuidField.md) class. |
| static [Factory](GuidField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [ConvertValue](GuidField/ConvertValue.md)(…) | Converts the value. |
| override [GetFromReader](GuidField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](GuidField/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](GuidField/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[GuidField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/GuidField.cs)*