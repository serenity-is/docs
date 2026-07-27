# ILanguageFallbacks.GetLanguageFallbacks method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the language fallbacks for specified language ID. It returns empty list for invariant language. For other language ID's the last element is always the invariant language ID.

```csharp
public IEnumerable<string> GetLanguageFallbacks(string languageID)
```

## See Also

* interface [ILanguageFallbacks](../ILanguageFallbacks.md)