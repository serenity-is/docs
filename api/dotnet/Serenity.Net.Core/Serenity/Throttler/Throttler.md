# Throttler constructor (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Initializes a new throttler backed by a distributed cache.

```csharp
public Throttler(IDistributedCache distributedCache, string key, TimeSpan duration, int limit)
```

| parameter | description |
| --- | --- |
| distributedCache | The distributed cache used to store attempt counts. |
| key | The cache key identifying the throttled resource, for example a username. |
| duration | The sliding window over which attempts are counted. |
| limit | The maximum number of attempts allowed within *duration*. |

## See Also

* class [Throttler](../Throttler.md)

---

# Throttler constructor (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Initializes a new throttler backed by an in-memory cache.

```csharp
public Throttler(IMemoryCache cache, string key, TimeSpan duration, int limit)
```

| parameter | description |
| --- | --- |
| cache | The memory cache used to store attempt counts. |
| key | The cache key identifying the throttled resource, for example a username. |
| duration | The sliding window over which attempts are counted. |
| limit | The maximum number of attempts allowed within *duration*. |

## See Also

* class [Throttler](../Throttler.md)