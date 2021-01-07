# Throttler class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Provides throttling checks for operations. E.g. allow 10 login attempts per minute.

```csharp
public class Throttler
```

## Public Members

| name | description |
| --- | --- |
| [Throttler](Throttler/Throttler.md)(…) | Creates a new throttler |
| [CacheKey](Throttler/CacheKey.md) { get; } | Full cache key |
| [Duration](Throttler/Duration.md) { get; } | Duration |
| [Key](Throttler/Key.md) { get; } | Cache key |
| [Limit](Throttler/Limit.md) { get; } | Limit |
| [Check](Throttler/Check.md)() | Checks if over throttle limit |
| [Reset](Throttler/Reset.md)() | Resets the throttle. |

## See Also

* **Source:** *[Throttler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/Throttler.cs)*