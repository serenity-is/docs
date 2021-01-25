# GenericField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Base generic class for fields with a value

```csharp
public abstract class GenericField<TValue> : Field
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |

## Public Members

| name | description |
| --- | --- |
| [GenericField](GenericField-1/GenericField.md)(…) | Initializes a new instance of the [`GenericField`](GenericField-1.md) class. |
| [Item](GenericField-1/Item.md) { get; set; } | Gets or sets the value of this field with the specified row. |
| override [Copy](GenericField-1/Copy.md)(…) | Copies the specified source. |

## Protected Members

| name | description |
| --- | --- |
| [_getValue](GenericField-1/_getValue.md) | The get value |
| [_setValue](GenericField-1/_setValue.md) | The set value |

## See Also

* class [Field](Field.md)
* **Source:** *[GenericField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/GenericField.cs)*