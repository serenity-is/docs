# RowFieldsBase.InsertItem method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Inserts an element into the Collection at the specified index.

```csharp
protected override void InsertItem(int index, Field item)
```

| parameter | description |
| --- | --- |
| index | The zero-based index at which *item* should be inserted. |
| item | The object to insert. The value can be `null` for reference types. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | field collection can't be modified! |
| ArgumentNullException | item |
| ArgumentOutOfRangeException | item |

## See Also

* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)