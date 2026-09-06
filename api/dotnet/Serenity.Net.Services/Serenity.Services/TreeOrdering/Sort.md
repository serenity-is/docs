# TreeOrdering.Sort&lt;TItem,TIdentity&gt; method

Applies tree based ordering to the items.

```csharp
public static List<TItem> Sort<TItem, TIdentity>(IEnumerable<TItem> items, 
    Func<TItem, TIdentity> getId, Func<TItem, TIdentity?> getParentId)
    where TIdentity : struct
```

| parameter | description |
| --- | --- |
| TItem | Type of items |
| TIdentity | Type of ID fields of the items |
| items | List of items |
| getId | Callback to get ID for an item |
| getParentId | Callback to get parent ID for an item |

## Return Value

The tree ordered list of items.

## See Also

* class [TreeOrdering](../TreeOrdering.md)