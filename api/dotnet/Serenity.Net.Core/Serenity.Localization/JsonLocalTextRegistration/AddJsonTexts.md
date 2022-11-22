# JsonLocalTextRegistration.AddJsonTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds translations from JSON files at specified path. File names in this directory should be in format {anyprefix}.{languageID}.json where {languageID} is a language code like 'en', 'en-GB' etc.

```csharp
public static void AddJsonTexts(this ILocalTextRegistry registry, string path, 
    IFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| registry | Registry |
| path | Path containing JSON files |
| fileSystem | File system |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [IFileSystem](../../Serenity/IFileSystem.md)
* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)