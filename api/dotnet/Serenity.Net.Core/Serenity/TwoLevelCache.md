# TwoLevelCache class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A two level cache that combines an in-memory cache with a distributed cache, keeping them in sync with optional group-based cache invalidation.

```csharp
public class TwoLevelCache : ITwoLevelCache
```

| parameter | description |
| --- | --- |
| memoryCache | Memory cache |
| distributedCache | Distributed cache |

## Public Members

| name | description |
| --- | --- |
| [TwoLevelCache](TwoLevelCache/TwoLevelCache.md)(…) | A two level cache that combines an in-memory cache with a distributed cache, keeping them in sync with optional group-based cache invalidation. |
| [Distributed](TwoLevelCache/Distributed.md) { get; } | Gets distributed cache |
| [Memory](TwoLevelCache/Memory.md) { get; } | Gets memory cache |
| static readonly [GenerationCacheExpiration](TwoLevelCache/GenerationCacheExpiration.md) | Expiration timeout for cache generation keys |
| const [GenerationSuffix](TwoLevelCache/GenerationSuffix.md) | Suffix for cache generation keys |

## Remarks

Creates a new TwoLevelCache instance

## See Also

* interface [ITwoLevelCache](../Serenity.Abstractions/ITwoLevelCache.md)
* **Source:** *[TwoLevelCache.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Caching/TwoLevelCache.cs)*