# Throttler class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Limits the rate of an operation, for example allowing only 10 login attempts per minute.

```csharp
public class Throttler
```

## Public Members

| name | description |
| --- | --- |
| [Throttler](Throttler/Throttler.md)(…) | Initializes a new throttler backed by an in-memory cache. (2 constructors) |
| [CacheKey](Throttler/CacheKey.md) { get; } | Gets the full cache key used to store the throttling state. |
| [Duration](Throttler/Duration.md) { get; } | Gets the sliding window duration. |
| [Key](Throttler/Key.md) { get; } | Gets the logical key identifying the throttled resource. |
| [Limit](Throttler/Limit.md) { get; } | Gets the maximum number of attempts allowed within [`Duration`](./Throttler/Duration.md). |
| [Check](Throttler/Check.md)() | Records an attempt and checks whether the throttling limit has been exceeded. |
| [Reset](Throttler/Reset.md)() | Clears the throttling state for the current key. |

## See Also

* **Source:** *[Throttler.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Authorization/Throttler.cs)*