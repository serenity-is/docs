# DeltaLister&lt;TItem&gt; constructor

Initializes a new instance of the [`DeltaLister`](../DeltaLister-1.md) class.

```csharp
public DeltaLister(IEnumerable<TItem> oldList, IEnumerable<TItem> newList, 
    Func<TItem, long?> getItemId, DeltaOptions options = DeltaOptions.Default)
```

| parameter | description |
| --- | --- |
| oldList | The old list. |
| newList | The new list. |
| getItemId | The function used to get the identifier of an item. Invoked exactly once per item, in the constructor. |
| options | The options. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | oldList, newList, getItemId, oldItem, oldItemId or newItem is null. |
| ArgumentOutOfRangeException | newItemId is not present in the old list. |
| ArgumentOutOfRangeException | newItemId is duplicated in the new list. |
| ArgumentException | An id is duplicated in the old list. |

## See Also

* enum [DeltaOptions](../DeltaOptions.md)
* class [DeltaLister&lt;TItem&gt;](../DeltaLister-1.md)