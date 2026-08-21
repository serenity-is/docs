# JsonLocalTextRegistration.AddJsonTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds translations from JSON files at the specified path. File names in this directory should be in the format {anyprefix}.{languageID}.json where {languageID} is a language code like 'en', 'en-GB', etc.

```csharp
public static void AddJsonTexts(this ILocalTextRegistry registry, string path, 
    IFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| registry | The registry to add texts to. |
| path | The path containing the JSON files. |
| fileSystem | The file system to use, or `null` to use the physical file system. |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [IFileSystem](../../Serenity/IFileSystem.md)
* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)