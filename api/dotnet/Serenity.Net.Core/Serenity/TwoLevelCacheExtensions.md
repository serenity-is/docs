# TwoLevelCacheExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains extension functions to use local and distributed cache in sync with optional cache invalidation.

```csharp
public static class TwoLevelCacheExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ExpireGroupItems](TwoLevelCacheExtensions/ExpireGroupItems.md)(…) | Changes a group generation value, so that all items that depend on it are expired. |
| static [Get&lt;TItem&gt;](TwoLevelCacheExtensions/Get.md)(…) | Tries to read a value from local cache. If it is not found there, tries the distributed cache. If neither contains the specified key, produces value by calling a loader function and adds the value to local and distributed cache for a given expiration time. By using a group key, all items on both cache types that are members of this group can be expired at once. (2 methods) |
| static [GetLocalStoreOnly&lt;TItem&gt;](TwoLevelCacheExtensions/GetLocalStoreOnly.md)(…) | Tries to read a value from local cache. If it is not found there produces value by calling a loader function and adds the value to local cache for a given expiration time. By using a generation (item version) key, all items on local cache that are members of this group can be expired at once. |
| static [Remove](TwoLevelCacheExtensions/Remove.md)(…) | Removes a key from local, distributed caches, and removes their generation version information. |

## See Also

* **Source:** *[TwoLevelCacheExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Caching/TwoLevelCacheExtensions.cs)*