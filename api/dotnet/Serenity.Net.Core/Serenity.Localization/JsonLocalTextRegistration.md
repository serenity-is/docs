# JsonLocalTextRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper methods for registration of local texts in hierarchical/dictionary formatted JSON files.

```csharp
public static class JsonLocalTextRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddFromNestedDictionary](JsonLocalTextRegistration/AddFromNestedDictionary.md)(…) | Adds translation from a hierarchical local text dictionary parsed from JSON file. |
| static [AddJsonTexts](JsonLocalTextRegistration/AddJsonTexts.md)(…) | Adds translations from JSON files at specified path. File names in this directory should be in format {anyprefix}.{languageID}.json where {languageID} is a language code like 'en', 'en-GB' etc. |
| static [ProcessNestedDictionary](JsonLocalTextRegistration/ProcessNestedDictionary.md)(…) | Converts translation from a hierarchical local text dictionary to a simple dictionary. |

## See Also

* **Source:** *[JsonLocalTextRegistration.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/JsonLocalTextRegistration.cs)*