# DistributedCacheExtensions.GetAutoJson&lt;TValue&gt; method

Gets a value from the cache as byte[], string, or using JSON deserialization depending on type

```csharp
public static TValue? GetAutoJson<TValue>(this IDistributedCache cache, string key)
    where TValue : class
```

| parameter | description |
| --- | --- |
| cache | Cache |
| key | Key |

## Return Value

The cached value, or `null` if the key does not exist in the cache.

## See Also

* class [DistributedCacheExtensions](../DistributedCacheExtensions.md)