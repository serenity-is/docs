# DefaultConnectionStrings class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The default connection string source.

```csharp
public class DefaultConnectionStrings : IConnectionKeyFallbacks, IConnectionStrings
```

| parameter | description |
| --- | --- |
| options | The connection string options. |
| sqlDialectMapper | The SQL dialect mapper. |
| typeSource | The type source used to discover connection key fallbacks. |

## Public Members

| name | description |
| --- | --- |
| [DefaultConnectionStrings](DefaultConnectionStrings/DefaultConnectionStrings.md)(…) | The default connection string source. |
| virtual [GetConnectionKeyFallbacks](DefaultConnectionStrings/GetConnectionKeyFallbacks.md)(…) |  |
| virtual [GetConnectionKeysResolvingTo](DefaultConnectionStrings/GetConnectionKeysResolvingTo.md)(…) | Returns all connection keys (including themselves) whose fallback chain resolves to the specified connection key. Only keys that actually resolve to a configured connection are included, so this is a configuration-aware operation. |
| virtual [ListConnectionStrings](DefaultConnectionStrings/ListConnectionStrings.md)() | Lists all known connection strings. |
| virtual [ResolveConnectionKey](DefaultConnectionStrings/ResolveConnectionKey.md)(…) |  |
| virtual [TryGetConnectionString](DefaultConnectionStrings/TryGetConnectionString.md)(…) | Gets a connection string by its key, resolving any connection key fallbacks. If the specified key is not configured but has a fallback, the fallback connection string is returned. The returned [`ConnectionKey`](./IConnectionString/ConnectionKey.md) is the key the connection is actually registered under. |

## Protected Members

| name | description |
| --- | --- |
| readonly [byKey](DefaultConnectionStrings/byKey.md) | The cached dictionary of connection string infos. |
| [fallbackMap](DefaultConnectionStrings/fallbackMap.md) | The lazily built connection key fallback map. |
| readonly [options](DefaultConnectionStrings/options.md) | The options. |
| readonly [sqlDialectMapper](DefaultConnectionStrings/sqlDialectMapper.md) | The SQL dialect mapper. |
| virtual [ApplyConfigFallbacks](DefaultConnectionStrings/ApplyConfigFallbacks.md)(…) | Applies config-driven fallbacks declared via [`FallbackFor`](./ConnectionStringEntry/FallbackFor.md) to the given map. These override any fallback declared by assembly attributes. If two configured connections declare the same connection key in [`FallbackFor`](./ConnectionStringEntry/FallbackFor.md), an InvalidOperationException is thrown because the fallback target is ambiguous. |
| virtual [DetermineDialect](DefaultConnectionStrings/DetermineDialect.md)(…) | Determines the dialect for a connection. |
| virtual [GetFallbackMap](DefaultConnectionStrings/GetFallbackMap.md)() | Gets the connection key fallback map. The default implementation builds it lazily on first access and caches it in [`fallbackMap`](./DefaultConnectionStrings/fallbackMap.md). Override to change caching or invalidation behavior, e.g. to return a fresh map each access (no caching). |
| static [BuildFallbackMap](DefaultConnectionStrings/BuildFallbackMap.md)(…) | Builds the connection key fallback map from the given type source. |

## Remarks

Creates a new instance of [`DefaultConnectionStrings`](./DefaultConnectionStrings.md).

## See Also

* interface [IConnectionKeyFallbacks](./IConnectionKeyFallbacks.md)
* interface [IConnectionStrings](./IConnectionStrings.md)
* **Source:** *[DefaultConnectionStrings.cs](https://github.com/serenity-is/Serenity/blob/478a0d557f5fa9d9eccec0603e34cc9daadb1091/src/services/Data/Connections/DefaultConnectionStrings.cs)*