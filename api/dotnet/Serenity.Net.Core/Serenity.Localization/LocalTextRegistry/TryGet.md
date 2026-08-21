# LocalTextRegistry.TryGet method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts the local text key to its representation in the requested language. Looks up the text in the requested language, its fallbacks, and the invariant language in order. If not found in any, `null` is returned. See [`SetLanguageFallback`](SetLanguageFallback.md) for information about language fallbacks.

```csharp
public string TryGet(string languageID, string textKey, bool pending)
```

| parameter | description |
| --- | --- |
| languageID | The language ID. |
| textKey | The local text key. |
| pending | `true` if pending approval texts should be used. |

## Return Value

The localized text, or `null` if none is found.

## See Also

* class [LocalTextRegistry](../LocalTextRegistry.md)