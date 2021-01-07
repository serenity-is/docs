# LocalTextRegistry.GetAllAvailableTextsInLanguage method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets all available text keys (that has a translation in language or any of its language fallbacks) and their local texts.

```csharp
public Dictionary<string, string> GetAllAvailableTextsInLanguage(string languageID, bool pending)
```

| parameter | description |
| --- | --- |
| languageID | Language ID (required). |
| pending | True if pending texts should be returned (e.g. in preview/edit mode). |

## Return Value

A dictionary of all texts in the language.

## See Also

* class [LocalTextRegistry](../LocalTextRegistry.md)