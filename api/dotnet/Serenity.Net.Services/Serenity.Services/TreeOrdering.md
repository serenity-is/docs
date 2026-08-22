# TreeOrdering class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Tree based sorting helper. E.g. in a tree, a node's parents should come before itself. Such an ordering is not easy in SQL so we use this helper to do ordering client side.

```csharp
public static class TreeOrdering
```

## Public Members

| name | description |
| --- | --- |
| static [Sort&lt;TItem,TIdentity&gt;](TreeOrdering/Sort.md)(…) | Applies tree based ordering to the items. |

## See Also

* **Source:** *[TreeOrdering.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Helpers/TreeOrdering.cs)*