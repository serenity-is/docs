# ITranslationKeyProvider interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Provides local text keys the application stores in its data, e.g. the keys that dashboards use for their titles, so that the translation page lists them for the translators, which it does only for the keys that are registered by the code and texts files otherwise. It only tells which keys there are and what text they are meant to be translated from, while the translated texts are in the local text registry.

```csharp
public interface ITranslationKeyProvider
```

## Members

| name | description |
| --- | --- |
| [GetKeys](ITranslationKeyProvider/GetKeys.md)() | Gets the keys with the texts they are meant to be translated from, which are what is shown for the key when it has no text in the registry. |

## See Also

* **Source:** *[ITranslationKeyProvider.cs](https://github.com/serenity-is/Serenity/blob/688a7cb009c05104411aafd01ab1b06d31fa5466/src/core/Localization/ITranslationKeyProvider.cs)*