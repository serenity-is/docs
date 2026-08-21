# ILanguageFallbacks.GetLanguageFallbacks method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the language fallbacks for the specified language ID. It returns an empty list for the invariant language. For other language IDs, the last element is always the invariant language ID.

```csharp
public IEnumerable<string> GetLanguageFallbacks(string languageID)
```

| parameter | description |
| --- | --- |
| languageID | The language ID. |

## Return Value

The sequence of language fallback IDs.

## See Also

* interface [ILanguageFallbacks](../ILanguageFallbacks.md)