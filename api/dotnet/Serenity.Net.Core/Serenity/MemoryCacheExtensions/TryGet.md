# MemoryCacheExtensions.TryGet&lt;TItem&gt; method

Reads the value of given type with specified key from the local cache. If the value doesn't exist or not of given type, it returns null.

```csharp
public static TItem? TryGet<TItem>(this IMemoryCache cache, string cacheKey)
    where TItem : class
```

| parameter | description |
| --- | --- |
| TItem | Expected type |
| cache | Cache |
| cacheKey | Key |

## See Also

* class [MemoryCacheExtensions](../MemoryCacheExtensions.md)