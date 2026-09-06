# MemoryCacheExtensions.Add&lt;TItem&gt; method

Adds a value to cache with a given key

```csharp
public static TItem Add<TItem>(this IMemoryCache cache, object key, TItem value, 
    TimeSpan expiration)
```

| parameter | description |
| --- | --- |
| cache | Cache |
| key | key |
| value | value |
| expiration | Expire time (Use TimeSpan.Zero to hold value with no expiration). If expiration is negative value nothing is added to the cache but removed if exists. |

## Return Value

The value that was added to the cache.

## See Also

* class [MemoryCacheExtensions](../MemoryCacheExtensions.md)