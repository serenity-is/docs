# BooleanField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with boolean value

```csharp
public sealed class BooleanField : GenericValueField<bool>
```

## Public Members

| name | description |
| --- | --- |
| [BooleanField](BooleanField/BooleanField.md)(…) | Initializes a new instance of the [`BooleanField`](BooleanField.md) class. |
| static [Factory](BooleanField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](BooleanField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](BooleanField/ValueFromJson.md)(…) | Gets field value from JSON. |
| override [ValueToJson](BooleanField/ValueToJson.md)(…) | Converts field value to json. |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[BooleanField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/BooleanField.cs)*