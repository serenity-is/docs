# Int16Field class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with Int16 value

```csharp
public sealed class Int16Field : GenericValueField<short>
```

## Public Members

| name | description |
| --- | --- |
| [Int16Field](Int16Field/Int16Field.md)(…) | Initializes a new instance of the [`Int16Field`](Int16Field.md) class. |
| static [Factory](Int16Field/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](Int16Field/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](Int16Field/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](Int16Field/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[Int16Field.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/Int16Field.cs)*