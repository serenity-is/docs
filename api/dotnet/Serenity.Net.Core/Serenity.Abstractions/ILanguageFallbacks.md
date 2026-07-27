# ILanguageFallbacks interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for local text registry that can return language fallbacks

```csharp
public interface ILanguageFallbacks
```

## Members

| name | description |
| --- | --- |
| [GetLanguageFallbacks](ILanguageFallbacks/GetLanguageFallbacks.md)(…) | Gets the language fallbacks for specified language ID. It returns empty list for invariant language. For other language ID's the last element is always the invariant language ID. |
| [SetLanguageFallback](ILanguageFallbacks/SetLanguageFallback.md)(…) | Sets the language fallback of the specified language. When a text is not found in one language, LocalTextRegistry checks its language fallback for a translation. Some implicit language fallback definitions exist even if none set. For example, "en" is language fallback ID of "en-US" and "en-UK", "tr" is language fallback ID of "tr-TR". Also, invariant language ID ("") is an implicit fallback of all languages. |

## See Also

* **Source:** *[ILanguageFallbacks.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Localization/ILanguageFallbacks.cs)*