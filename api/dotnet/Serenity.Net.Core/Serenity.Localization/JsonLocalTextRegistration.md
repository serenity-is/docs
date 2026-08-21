# JsonLocalTextRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper methods for registration of local texts in hierarchical or dictionary formatted JSON files.

```csharp
public static class JsonLocalTextRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddFromNestedDictionary](JsonLocalTextRegistration/AddFromNestedDictionary.md)(…) | Adds translations from a hierarchical local text dictionary parsed from a JSON file. |
| static [AddJsonResourceTexts](JsonLocalTextRegistration/AddJsonResourceTexts.md)(…) | Adds JSON texts from embedded resources. (2 methods) |
| static [AddJsonTexts](JsonLocalTextRegistration/AddJsonTexts.md)(…) | Adds translations from JSON files at the specified path. File names in this directory should be in the format {anyprefix}.{languageID}.json where {languageID} is a language code like 'en', 'en-GB', etc. |
| static [ParseLanguageIdFromPath](JsonLocalTextRegistration/ParseLanguageIdFromPath.md)(…) | Parses the language ID from the file path. |
| static [ProcessNestedDictionary&lt;TValue&gt;](JsonLocalTextRegistration/ProcessNestedDictionary.md)(…) | Converts translations from a hierarchical local text dictionary to a simple dictionary. |

## See Also

* **Source:** *[JsonLocalTextRegistration.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Localization/JsonLocalTextRegistration.cs)*