# TwoLevelCache constructor

A two level cache that combines an in-memory cache with a distributed cache, keeping them in sync with optional group-based cache invalidation.

```csharp
public TwoLevelCache(IMemoryCache memoryCache, IDistributedCache distributedCache)
```

| parameter | description |
| --- | --- |
| memoryCache | Memory cache |
| distributedCache | Distributed cache |

## Remarks

Creates a new TwoLevelCache instance

## See Also

* class [TwoLevelCache](../TwoLevelCache.md)