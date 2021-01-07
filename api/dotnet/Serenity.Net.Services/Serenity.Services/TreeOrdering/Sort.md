# TreeOrdering.Sort&lt;TItem,TIdentity&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public static List<TItem> Sort<TItem, TIdentity>(IEnumerable<TItem> items, 
    Func<TItem, TIdentity> getId, Func<TItem, TIdentity?> getParentId)
    where TIdentity : struct
```

## See Also

* class [TItem](../Serenity.Net.Services/../TreeOrdering.TItem.md)
* struct [TIdentity](../Serenity.Net.Services/../TreeOrdering.TIdentity.md)
* class [TreeOrdering](../TreeOrdering.md)