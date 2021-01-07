# DeltaLister&lt;TItem&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Helper class to find differences between to lists for updating

```csharp
public class DeltaLister<TItem>
```

| parameter | description |
| --- | --- |
| TItem | The type of the item. |

## Public Members

| name | description |
| --- | --- |
| [DeltaLister](DeltaLister-1/DeltaLister.md)(…) | Initializes a new instance of the [`DeltaLister`](DeltaLister-1.md) class. |
| [ItemsToCreate](DeltaLister-1/ItemsToCreate.md) { get; } | Gets the items to create. |
| [ItemsToDelete](DeltaLister-1/ItemsToDelete.md) { get; } | Gets the items to delete. |
| [ItemsToUpdate](DeltaLister-1/ItemsToUpdate.md) { get; } | Gets the items to update. |

## See Also

* **Source:** *[DeltaLister.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Utility/DeltaLister.cs)*