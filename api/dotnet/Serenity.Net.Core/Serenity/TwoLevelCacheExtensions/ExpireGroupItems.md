# TwoLevelCacheExtensions.ExpireGroupItems method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Changes a group generation value, so that all items that depend on it are expired.

```csharp
public static void ExpireGroupItems(this ITwoLevelCache cache, string groupKey)
```

| parameter | description |
| --- | --- |
| cache | Two level cache |
| groupKey | Group key |

## See Also

* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [TwoLevelCacheExtensions](../TwoLevelCacheExtensions.md)