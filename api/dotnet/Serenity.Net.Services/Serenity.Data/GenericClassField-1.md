# GenericClassField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for fields with reference type values.

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
| override [AsObject](GenericClassField-1/AsObject.md)(…) | Sets the value of this field in specified row as object. |
| override [AsObjectNoCheck](GenericClassField-1/AsObjectNoCheck.md)(…) |  |
| override [ConvertValue](GenericClassField-1/ConvertValue.md)(…) | Converts the value. |
| override [Copy](GenericClassField-1/Copy.md)(…) | Copies the specified source. |
| override [IndexCompare](GenericClassField-1/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort using the specified comparer, falling back to [`Comparer`](./Field/Comparer.md) when it is null. |
| override [IsNullNoCheck](GenericClassField-1/IsNullNoCheck.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [_getValue](GenericClassField-1/_getValue.md) | The get value callback. |
| [_setValue](GenericClassField-1/_setValue.md) | The set value callback. |
| virtual [CompareValues](GenericClassField-1/CompareValues.md)(…) | Compares two values of this field using the specified comparer. |

## See Also

* class [Field](./Field.md)
* **Source:** *[GenericClassField.cs](https://github.com/serenity-is/Serenity/blob/f828b609b385564332aeeec6f0d6a031cde4142f/src/services/Entity/FieldTypes/GenericClassField.cs)*