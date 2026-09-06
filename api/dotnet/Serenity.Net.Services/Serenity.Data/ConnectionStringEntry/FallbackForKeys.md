# ConnectionStringEntry.FallbackForKeys property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the parsed, trimmed connection keys from [`FallbackFor`](FallbackFor.md), split on ';'. Returns an empty set when [`FallbackFor`](FallbackFor.md) is null or empty. Parsed lazily and cached.

```csharp
public IReadOnlyCollection<string> FallbackForKeys { get; }
```

## See Also

* class [ConnectionStringEntry](../ConnectionStringEntry.md)