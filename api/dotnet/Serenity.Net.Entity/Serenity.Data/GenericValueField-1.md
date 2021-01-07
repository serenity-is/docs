# GenericValueField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

```csharp
public abstract class GenericValueField<TValue> : Field, IEnumTypeField
    where TValue : struct, IComparable<TValue>
```

## Public Members

| name | description |
| --- | --- |
| [EnumType](GenericValueField-1/EnumType.md) { get; set; } |  |
| [Item](GenericValueField-1/Item.md) { get; set; } |  |
| override [ValueType](GenericValueField-1/ValueType.md) { get; } |  |
| override [AsObject](GenericValueField-1/AsObject.md)(…) |  (2 methods) |
| override [ConvertValue](GenericValueField-1/ConvertValue.md)(…) |  |
| override [Copy](GenericValueField-1/Copy.md)(…) |  |
| override [IndexCompare](GenericValueField-1/IndexCompare.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [_enumType](GenericValueField-1/_enumType.md) |  |
| [_getValue](GenericValueField-1/_getValue.md) |  |
| [_setValue](GenericValueField-1/_setValue.md) |  |
| override [GetIsNull](GenericValueField-1/GetIsNull.md)(…) |  |

## See Also

* class [Field](Field.md)
* interface [IEnumTypeField](IEnumTypeField.md)
* struct [TValue](../Serenity.Net.Entity/GenericValueField-1.TValue.md)
* **Source:** *[GenericValueField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/GenericValueField.cs)*