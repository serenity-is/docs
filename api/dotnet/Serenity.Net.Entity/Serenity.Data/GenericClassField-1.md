# GenericClassField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Base class for fields with reference type values

```csharp
public abstract class GenericClassField<TValue> : Field
    where TValue : class
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |

## Public Members

| name | description |
| --- | --- |
| [Item](GenericClassField-1/Item.md) { get; set; } | Gets or sets the value of this field with the specified row. |
| override [ValueType](GenericClassField-1/ValueType.md) { get; } | Gets the type of the value. |
| override [AsObject](GenericClassField-1/AsObject.md)(…) | Gets the value of this field in specified row as object. (2 methods) |
| override [ConvertValue](GenericClassField-1/ConvertValue.md)(…) | Converts the value. |
| override [Copy](GenericClassField-1/Copy.md)(…) | Copies the specified source. |

## Protected Members

| name | description |
| --- | --- |
| [_getValue](GenericClassField-1/_getValue.md) | The get value callback |
| [_setValue](GenericClassField-1/_setValue.md) | The set value callback |
| override [GetIsNull](GenericClassField-1/GetIsNull.md)(…) | Gets if the field value is null. |

## See Also

* class [Field](Field.md)
* **Source:** *[GenericClassField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/GenericClassField.cs)*