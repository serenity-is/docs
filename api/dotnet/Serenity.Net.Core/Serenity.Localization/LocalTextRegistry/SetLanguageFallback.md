# LocalTextRegistry.SetLanguageFallback method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Sets the language fallback of the specified language. When a text is not found in one language, LocalTextRegistry checks its language fallback for a translation. Some implicit language fallback definitions exist even if none set. For example, "en" is language fallback ID of "en-US" and "en-UK", "tr" is language fallback ID of "tr-TR". Also, invariant language ID ("") is an implicit fallback of all languages.

```csharp
public void SetLanguageFallback(string languageID, string languageFallbackID)
```

| parameter | description |
| --- | --- |
| languageID | Language identifier. (e.g. en-US) |
| languageFallbackID | language fallback identifier. (e.g. en) |

## See Also

* class [LocalTextRegistry](../LocalTextRegistry.md)