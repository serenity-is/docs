# LocalTextRegistry.TryGet method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Converts the local text key to its representation in requested language. Looks up text in requested language, its Fallbacks and invariant language in order. If not found in any, null is returned. See SetLanguageFallback for information about language fallbacks.

```csharp
public string TryGet(string languageID, string textKey, bool pending)
```

| parameter | description |
| --- | --- |
| languageID | Language ID. |
| textKey | Local text key (can be null). |
| pending | If pending approval texts to be used, true. |

## See Also

* class [LocalTextRegistry](../LocalTextRegistry.md)