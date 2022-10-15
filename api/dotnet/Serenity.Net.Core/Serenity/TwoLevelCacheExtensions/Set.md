# TwoLevelCacheExtensions.Set&lt;TItem&gt; method (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates or overrides a specified entry in the local and distributed cache.

```csharp
public static TItem Set<TItem>(this ITwoLevelCache cache, string cacheKey, TimeSpan expiration, 
    string groupKey, TItem value)
    where TItem : class
```

| parameter | description |
| --- | --- |
| TItem | Data type |
| cache | Two level cache |
| cacheKey | The item key for local and distributed cache |
| expiration | Local and remote expiration |
| groupKey | Group key that will hold generation (version). Can be used to expire all items that depend on it. This can be a table name. When a table changes, you change its version, and all cached data that depends on that table is expired. |
| value | Value to set. |

## See Also

* class [TItem](../Serenity.Net.Core/../TwoLevelCacheExtensions.TItem.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [TwoLevelCacheExtensions](../TwoLevelCacheExtensions.md)

---

# TwoLevelCacheExtensions.Set&lt;TItem&gt; method (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates or overrides a specified entry in the local and distributed cache.

```csharp
public static TItem Set<TItem>(this ITwoLevelCache cache, string cacheKey, 
    TimeSpan localExpiration, TimeSpan remoteExpiration, string groupKey, TItem value)
    where TItem : class
```

| parameter | description |
| --- | --- |
| TItem | Data type |
| cache | Two level cache |
| cacheKey | The item key for local and distributed cache |
| localExpiration | Local expiration |
| remoteExpiration | Distributed cache expiration (is usually same with local expiration) |
| groupKey | Group key that will hold generation (version). Can be used to expire all items that depend on it. This can be a table name. When a table changes, you change its version, and all cached data that depends on that table is expired. |
| value | Value to set. |

## See Also

* class [TItem](../Serenity.Net.Core/../TwoLevelCacheExtensions.TItem.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [TwoLevelCacheExtensions](../TwoLevelCacheExtensions.md)