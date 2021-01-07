# TwoLevelCacheExtensions.Remove method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Removes a key from local, distributed caches, and removes their generation version information.

```csharp
public static void Remove(this ITwoLevelCache cache, string cacheKey)
```

| parameter | description |
| --- | --- |
| cache | Two level cache |
| cacheKey | Cache key |

## See Also

* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [TwoLevelCacheExtensions](../TwoLevelCacheExtensions.md)