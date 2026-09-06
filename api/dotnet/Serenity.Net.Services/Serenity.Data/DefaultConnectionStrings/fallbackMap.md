# DefaultConnectionStrings.fallbackMap field

The lazily built connection key fallback map.

```csharp
protected Dictionary<string, string> fallbackMap;
```

## Remarks

Built on first access via [`GetFallbackMap`](./GetFallbackMap.md). A derived implementation can override [`GetFallbackMap`](./GetFallbackMap.md) to avoid caching, or set this field to `null` to invalidate it so it is rebuilt on the next access.

## See Also

* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)