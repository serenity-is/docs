# Throttler constructor (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a new throttler

```csharp
public Throttler(IDistributedCache distributedCache, string key, TimeSpan duration, int limit)
```

| parameter | description |
| --- | --- |
| distributedCache | Distributed cache |
| key | Cache key for throttler. Include the resource name, e.g. username, you are throttling |
| duration | Check period |
| limit | How many times are allowed |

## See Also

* class [Throttler](../Throttler.md)

---

# Throttler constructor (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a new throttler

```csharp
public Throttler(IMemoryCache cache, string key, TimeSpan duration, int limit)
```

| parameter | description |
| --- | --- |
| cache | Memory cache |
| key | Cache key for throttler. Include the resource name, e.g. username, you are throttling |
| duration | Check period |
| limit | How many times are allowed |

## See Also

* class [Throttler](../Throttler.md)