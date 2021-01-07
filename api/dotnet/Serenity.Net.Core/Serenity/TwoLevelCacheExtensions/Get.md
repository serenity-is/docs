# TwoLevelCacheExtensions.Get&lt;TItem&gt; method (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to read a value from local cache. If it is not found there, tries the distributed cache. If neither contains the specified key, produces value by calling a loader function and adds the value to local and distributed cache for a given expiration time. By using a group key, all items on both cache types that are members of this group can be expired at once.

```csharp
public static TItem Get<TItem>(this ITwoLevelCache cache, string cacheKey, TimeSpan expiration, 
    string groupKey, Func<TItem> loader)
    where TItem : class
```

| parameter | description |
| --- | --- |
| TItem | Data type |
| cache | Two level cache |
| cacheKey | The item key for local and distributed cache |
| expiration | Local and remote expiration |
| groupKey | Group key that will hold generation (version). Can be used to expire all items that depend on it. This can be a table name. When a table changes, you change its version, and all cached data that depends on that table is expired. |
| loader | The delegate that will be called to generate value, if not found in local cache, or distributed cache, or all found items are expired. |

## Remarks

To not check group generation every time an item is requested, generation number itself is also cached in local cache. Thus, when a generation number changes, local cached items might expire after about 5 seconds. This means that, if you use this strategy in a web farm setup, when a change occurs in one server, other servers might continue to use old local cached data for 5 seconds more. If this is a problem for your configuration, use DistributedCache directly.

## See Also

* class [TItem](../Serenity.Net.Core/../TwoLevelCacheExtensions.TItem.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [TwoLevelCacheExtensions](../TwoLevelCacheExtensions.md)

---

# TwoLevelCacheExtensions.Get&lt;TItem&gt; method (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Tries to read a value from local cache. If it is not found there, tries the distributed cache. If neither contains the specified key, produces value by calling a loader function and adds the value to local and distributed cache for a given expiration time. By using a group key, all items on both cache types that are members of this group can be expired at once.

```csharp
public static TItem Get<TItem>(this ITwoLevelCache cache, string cacheKey, 
    TimeSpan localExpiration, TimeSpan remoteExpiration, string groupKey, Func<TItem> loader)
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
| loader | The delegate that will be called to generate value, if not found in local cache, or distributed cache, or all found items are expired. |

## Remarks

To not check group generation every time an item is requested, generation number itself is also cached in local cache. Thus, when a generation number changes, local cached items might expire after about 5 seconds. This means that, if you use this strategy in a web farm setup, when a change occurs in one server, other servers might continue to use old local cached data for 5 seconds more. If this is a problem for your configuration, use DistributedCache directly.

## See Also

* class [TItem](../Serenity.Net.Core/../TwoLevelCacheExtensions.TItem.md)
* interface [ITwoLevelCache](../../Serenity.Abstractions/ITwoLevelCache.md)
* class [TwoLevelCacheExtensions](../TwoLevelCacheExtensions.md)