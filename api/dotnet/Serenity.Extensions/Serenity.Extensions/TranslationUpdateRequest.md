# TranslationUpdateRequest class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

The request model for updating user translations.

```csharp
public class TranslationUpdateRequest : ServiceRequest
```

## Public Members

| name | description |
| --- | --- |
| [TranslationUpdateRequest](TranslationUpdateRequest/TranslationUpdateRequest.md)() | The default constructor. |
| [TargetLanguageID](TranslationUpdateRequest/TargetLanguageID.md) { get; set; } | The target language ID. |
| [Translations](TranslationUpdateRequest/Translations.md) { get; set; } | The dictionary of text keys and their translated values. |

## See Also

* class [ServiceRequest](../../Serenity.Net.Services/Serenity.Services/ServiceRequest.md)
* **Source:** *[TranslationUpdateRequest.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/Translation/TranslationUpdateRequest.cs)*