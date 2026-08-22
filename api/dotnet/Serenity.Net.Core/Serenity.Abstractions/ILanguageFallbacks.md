# ILanguageFallbacks interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for a local text registry that can return language fallbacks.

```csharp
public interface ILanguageFallbacks
```

## Members

| name | description |
| --- | --- |
| [GetLanguageFallbacks](ILanguageFallbacks/GetLanguageFallbacks.md)(…) | Gets the language fallbacks for the specified language ID. It returns an empty list for the invariant language. For other language IDs, the last element is always the invariant language ID. |
| [SetLanguageFallback](ILanguageFallbacks/SetLanguageFallback.md)(…) | Sets the language fallback of the specified language. When a text is not found in one language, the local text registry checks its language fallback for a translation. Some implicit language fallback definitions exist even if none are set. For example, "en" is the language fallback ID of "en-US" and "en-UK", and "tr" is the language fallback ID of "tr-TR". Also, the invariant language ID ("") is an implicit fallback of all languages. |

## See Also

* **Source:** *[ILanguageFallbacks.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/ILanguageFallbacks.cs)*