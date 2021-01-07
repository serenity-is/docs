# DeltaLister&lt;TItem&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`DeltaLister`](../DeltaLister-1.md) class.

```csharp
public DeltaLister(IEnumerable<TItem> oldList, IEnumerable<TItem> newList, 
    Func<TItem, long?> getItemId, DeltaOptions options = DeltaOptions.IgnoreInvalidNewId)
```

| parameter | description |
| --- | --- |
| oldList | The old list. |
| newList | The new list. |
| getItemId | The get item identifier. |
| options | The options. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | oldList or newList or getItemId or oldItem or oldItemId or newItem is null. |
| ArgumentOutOfRangeException | newItemId |
| DuplicateNameException | newItemId |

## See Also

* class [TItem](../Serenity.Net.Data/../DeltaLister-1.TItem.md)
* enum [DeltaOptions](../DeltaOptions.md)
* class [DeltaLister&lt;TItem&gt;](../DeltaLister-1.md)