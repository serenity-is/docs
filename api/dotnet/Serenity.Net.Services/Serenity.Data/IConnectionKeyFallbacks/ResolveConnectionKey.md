# IConnectionKeyFallbacks.ResolveConnectionKey method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Resolves a connection key to the first key in its fallback chain that is actually configured. Returns `null` if none of the keys in the chain are configured.

```csharp
public string ResolveConnectionKey(string connectionKey)
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |

## Return Value

The resolved connection key, or `null`.

## See Also

* interface [IConnectionKeyFallbacks](../IConnectionKeyFallbacks.md)