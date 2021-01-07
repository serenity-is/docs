# JsonLocalTextRegistration.AddJsonTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds translations from JSON files at specified path. File names in this directory should be in format {anyprefix}.{languageID}.json where {languageID} is a language code like 'en', 'en-GB' etc.

```csharp
public static void AddJsonTexts(this ILocalTextRegistry registry, string path)
```

| parameter | description |
| --- | --- |
| path | Path containing JSON files |
| registry | Registry |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)