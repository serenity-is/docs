# RowFieldsBase.SetItem method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Replaces the element at the specified index.

```csharp
protected override void SetItem(int index, Field item)
```

| parameter | description |
| --- | --- |
| index | The zero-based index of the element to replace. |
| item | The new value for the element at the specified index. The value can be `null` for reference types. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | field collection can't be modified! |
| ArgumentNullException | item |
| ArgumentOutOfRangeException | item |

## See Also

* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)