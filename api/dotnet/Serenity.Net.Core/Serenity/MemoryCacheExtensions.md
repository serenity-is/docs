# MemoryCacheExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains extensions methods to work with IMemoryCache provider.

```csharp
public static class MemoryCacheExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [Add&lt;TItem&gt;](MemoryCacheExtensions/Add.md)(…) | Adds a value to cache with a given key |
| static [Get&lt;TItem&gt;](MemoryCacheExtensions/Get.md)(…) | Reads the value with specified key from the local cache. If it doesn't exists in cache, calls the loader function to generate value (from database etc.) and adds it to the cache. If loader returns a null value, it is written to the cache as DBNull.Value. |
| static [RemoveAll](MemoryCacheExtensions/RemoveAll.md)(…) | Removes all items from the cache (avoid except unit tests). |
| static [TryGet&lt;TItem&gt;](MemoryCacheExtensions/TryGet.md)(…) | Reads the value of given type with specified key from the local cache. If the value doesn't exist or not of given type, it returns null. |

## See Also

* **Source:** *[MemoryCacheExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Caching/MemoryCacheExtensions.cs)*