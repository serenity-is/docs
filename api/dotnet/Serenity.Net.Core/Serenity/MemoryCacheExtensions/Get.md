# MemoryCacheExtensions.Get&lt;TItem&gt; method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Reads the value with specified key from the local cache. If it doesn't exists in cache, calls the loader function to generate value (from database etc.) and adds it to the cache. If loader returns a null value, it is written to the cache as DBNull.Value.

```csharp
public static TItem Get<TItem>(this IMemoryCache cache, object cacheKey, TimeSpan expiration, 
    Func<TItem> loader)
    where TItem : class
```

| parameter | description |
| --- | --- |
| TItem | Data type |
| cache | Cache |
| cacheKey | Key |
| expiration | Expiration (TimeSpan.Zero means no expiration) |
| loader | Loader function that will be called if item doesn't exist in the cache. |

## See Also

* class [TItem](../Serenity.Net.Core/../MemoryCacheExtensions.TItem.md)
* class [MemoryCacheExtensions](../MemoryCacheExtensions.md)