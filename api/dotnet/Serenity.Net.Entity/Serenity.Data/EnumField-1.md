# EnumField&lt;TEnum&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with an Enum value

```csharp
public class EnumField<TEnum> : Int32Field
    where TEnum : struct, IComparable, IFormattable, IConvertible
```

| parameter | description |
| --- | --- |
| TEnum | The type of the enum. |

## Public Members

| name | description |
| --- | --- |
| [EnumField](EnumField-1/EnumField.md)(…) | Initializes a new instance of the [`EnumField`](EnumField-1.md) class. |
| [Item](EnumField-1/Item.md) { get; set; } | Gets or sets the value of this field with the specified row. |

## See Also

* class [Int32Field](Int32Field.md)
* **Source:** *[EnumField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/EnumField.cs)*