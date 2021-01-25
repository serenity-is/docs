# Int32Field class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with Int32 value

```csharp
public class Int32Field : GenericValueField<int>
```

## Public Members

| name | description |
| --- | --- |
| [Int32Field](Int32Field/Int32Field.md)(…) | Initializes a new instance of the [`Int32Field`](Int32Field.md) class. |
| static [Factory](Int32Field/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](Int32Field/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](Int32Field/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](Int32Field/ValueToJson.md)(…) | Serializes this fields value to JSON |

## See Also

* class [GenericValueField&lt;TValue&gt;](GenericValueField-1.md)
* **Source:** *[Int32Field.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/Int32Field.cs)*