# GenericValueField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for fields with a value type value.

```csharp
public abstract class GenericValueField<TValue> : Field, IEnumTypeField
    where TValue : struct, IComparable<TValue>
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |

## Public Members

| name | description |
| --- | --- |
| [EnumType](GenericValueField-1/EnumType.md) { get; set; } | Gets or sets the type of the enum. |
| [Item](GenericValueField-1/Item.md) { get; set; } | Gets or sets the value of this field with the specified row. |
| override [ValueType](GenericValueField-1/ValueType.md) { get; } | Gets the type of the value. |
| override [AsObject](GenericValueField-1/AsObject.md)(…) | Sets the value of this field in specified row as object. |
| override [AsObjectNoCheck](GenericValueField-1/AsObjectNoCheck.md)(…) |  |
| override [ConvertValue](GenericValueField-1/ConvertValue.md)(…) | Converts the value. |
| override [Copy](GenericValueField-1/Copy.md)(…) | Copies the specified source. |
| override [IndexCompare](GenericValueField-1/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort using the specified comparer, falling back to [`Comparer`](./Field/Comparer.md) when it is null. |
| override [IsNullNoCheck](GenericValueField-1/IsNullNoCheck.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [_enumType](GenericValueField-1/_enumType.md) | The enum type. |
| [_getValue](GenericValueField-1/_getValue.md) | The get value. |
| [_setValue](GenericValueField-1/_setValue.md) | The set value. |
| virtual [CompareValues](GenericValueField-1/CompareValues.md)(…) | Compares two values of this field using the specified comparer. |

## See Also

* class [Field](./Field.md)
* interface [IEnumTypeField](./IEnumTypeField.md)
* **Source:** *[GenericValueField.cs](https://github.com/serenity-is/Serenity/blob/f828b609b385564332aeeec6f0d6a031cde4142f/src/services/Entity/FieldTypes/GenericValueField.cs)*