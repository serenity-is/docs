# TwoLevelCache class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper functions to use local and distributed cache in sync with optional cache invalidation.

```csharp
public class TwoLevelCache : ITwoLevelCache
```

## Public Members

| name | description |
| --- | --- |
| [TwoLevelCache](TwoLevelCache/TwoLevelCache.md)(…) | Creates a new TwoLevelCache instance |
| [Distributed](TwoLevelCache/Distributed.md) { get; } | Gets distributed cache |
| [Memory](TwoLevelCache/Memory.md) { get; } | Gets memory cache |
| static readonly [GenerationCacheExpiration](TwoLevelCache/GenerationCacheExpiration.md) | Expiration timeout for cache generation keys |
| const [GenerationSuffix](TwoLevelCache/GenerationSuffix.md) | Suffix for cache generation keys |

## See Also

* interface [ITwoLevelCache](../Serenity.Abstractions/ITwoLevelCache.md)
* **Source:** *[TwoLevelCache.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Caching/TwoLevelCache.cs)*