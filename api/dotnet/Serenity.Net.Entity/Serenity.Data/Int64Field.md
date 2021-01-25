# Int64Field class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with Int64 value

```csharp
public sealed class Int64Field : GenericValueField<long>
```

## Public Members

| name | description |
| --- | --- |
| [Int64Field](Int64Field/Int64Field.md)(…) | Initializes a new instance of the [`Int64Field`](Int64Field.md) class. |
| static [Factory](Int64Field/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](Int64Field/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](Int64Field/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](Int64Field/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[Int64Field.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/Int64Field.cs)*