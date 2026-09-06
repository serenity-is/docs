# IConnectionKeyFallbacks interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction to access connection key fallbacks.

```csharp
public interface IConnectionKeyFallbacks
```

## Members

| name | description |
| --- | --- |
| [GetConnectionKeyFallbacks](IConnectionKeyFallbacks/GetConnectionKeyFallbacks.md)(…) | Gets the ordered fallback chain for a connection key, starting with the key itself followed by its declared fallbacks. This reflects only the declared [`ConnectionKeyFallbackAttribute`](ConnectionKeyFallbackAttribute.md) values and does not check configuration. |
| [GetConnectionKeysResolvingTo](IConnectionKeyFallbacks/GetConnectionKeysResolvingTo.md)(…) | Returns all connection keys (including themselves) whose fallback chain resolves to the specified connection key. Only keys that actually resolve to a configured connection are included, so this is a configuration-aware operation. |
| [ResolveConnectionKey](IConnectionKeyFallbacks/ResolveConnectionKey.md)(…) | Resolves a connection key to the first key in its fallback chain that is actually configured. Returns `null` if none of the keys in the chain are configured. |

## Remarks

A connection key fallback maps a logical connection key (e.g. "ProMeeting") to another connection key (e.g. "Default") that should be used when the logical key is not present in configuration. This allows feature modules to declare their own connection key while still working in applications that only configure the fallback key.

## See Also

* **Source:** *[IConnectionKeyFallbacks.cs](https://github.com/serenity-is/Serenity/blob/d7ef4960ed2723e5081d907f7610b7cabba6cf08/src/services/Data/Connections/IConnectionKeyFallbacks.cs)*