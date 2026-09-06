# IConnectionKeyFallbacks.GetConnectionKeyFallbacks method

Gets the ordered fallback chain for a connection key, starting with the key itself followed by its declared fallbacks. This reflects only the declared [`ConnectionKeyFallbackAttribute`](../ConnectionKeyFallbackAttribute.md) values and does not check configuration.

```csharp
public IEnumerable<string> GetConnectionKeyFallbacks(string connectionKey)
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |

## Return Value

The ordered fallback chain.

## See Also

* interface [IConnectionKeyFallbacks](../IConnectionKeyFallbacks.md)