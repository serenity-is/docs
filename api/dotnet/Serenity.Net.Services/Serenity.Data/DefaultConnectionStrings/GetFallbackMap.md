# DefaultConnectionStrings.GetFallbackMap method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the connection key fallback map. The default implementation builds it lazily on first access and caches it in [`fallbackMap-`](fallbackMap-.md). Override to change caching or invalidation behavior, e.g. to return a fresh map each access (no caching).

```csharp
protected virtual Dictionary<string, string> GetFallbackMap()
```

## See Also

* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)