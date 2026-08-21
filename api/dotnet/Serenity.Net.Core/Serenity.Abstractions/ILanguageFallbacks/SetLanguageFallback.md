# ILanguageFallbacks.SetLanguageFallback method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Sets the language fallback of the specified language. When a text is not found in one language, the local text registry checks its language fallback for a translation. Some implicit language fallback definitions exist even if none are set. For example, "en" is the language fallback ID of "en-US" and "en-UK", and "tr" is the language fallback ID of "tr-TR". Also, the invariant language ID ("") is an implicit fallback of all languages.

```csharp
public void SetLanguageFallback(string languageID, string fallbackID)
```

| parameter | description |
| --- | --- |
| languageID | The language identifier (e.g. en-US). |
| fallbackID | The language fallback identifier (e.g. en). |

## See Also

* interface [ILanguageFallbacks](../ILanguageFallbacks.md)