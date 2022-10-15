# TwoLevelCacheExtensions.SetLocalStoreOnly&lt;TItem&gt; method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates or overrides a specified entry in the local cache.

```csharp
public static TItem SetLocalStoreOnly<TItem>(this ITwoLevelCache cache, string cacheKey, 
    TimeSpan localExpiration, string groupKey, TItem value)
    where TItem : class
```

| parameter | description |
| --- | --- |
| TItem | Data type |
| cache | Two level cache |
| cacheKey | The item key for local and distributed cache |
| localExpiration | Local expiration |
| groupKey | Group key that will hold generation (version). Can be used to expire all items that depend on it. This can be a table name. When a table changes, you change its version, and all cached data that depends on that table is expired. |
| value | Value to set. |

## See Also

* class [TItem](../Serenity.Net.Core/../TwoLevelCacheExtensions.TItem.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [TwoLevelCacheExtensions](../TwoLevelCacheExtensions.md)