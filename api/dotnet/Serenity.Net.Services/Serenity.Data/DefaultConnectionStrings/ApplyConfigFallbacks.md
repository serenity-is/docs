# DefaultConnectionStrings.ApplyConfigFallbacks method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies config-driven fallbacks declared via [`FallbackFor`](../ConnectionStringEntry/FallbackFor.md) to the given map. These override any fallback declared by assembly attributes. If two configured connections declare the same connection key in [`FallbackFor`](../ConnectionStringEntry/FallbackFor.md), an InvalidOperationException is thrown because the fallback target is ambiguous.

```csharp
protected virtual void ApplyConfigFallbacks(Dictionary<string, string> map)
```

| parameter | description |
| --- | --- |
| map | The fallback map to apply configuration fallbacks to. |

## See Also

* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)