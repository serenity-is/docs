# Throttler constructor
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a new throttler

```csharp
public Throttler(IMemoryCache cache, string key, TimeSpan duration, int limit)
```

| parameter | description |
| --- | --- |
| cache | Cache |
| key | Cache key for throttler. Include the resource name, e.g. username, you are throttling |
| duration | Check period |
| limit | How many times are allowed |

## See Also

* class [Throttler](../Throttler.md)