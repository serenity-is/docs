# ConnectionStringEntry.FallbackFor property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets or sets a semicolon-separated list of connection keys that fall back to this connection when they are not configured. For example, "ProFeatures;ProWorkLog".

```csharp
public string FallbackFor { get; set; }
```

## Remarks

This is equivalent to declaring `[assembly: ConnectionKeyFallback(key, thisConnectionKey)]` for each listed key, but is driven by configuration and overrides any such assembly attribute.

## See Also

* class [ConnectionStringEntry](../ConnectionStringEntry.md)