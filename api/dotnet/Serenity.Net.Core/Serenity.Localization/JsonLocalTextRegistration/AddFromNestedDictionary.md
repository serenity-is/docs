# JsonLocalTextRegistration.AddFromNestedDictionary method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds translations from a hierarchical local text dictionary parsed from a JSON file.

```csharp
public static void AddFromNestedDictionary(IDictionary<string, object> nested, string prefix, 
    string languageID, ILocalTextRegistry registry)
```

| parameter | description |
| --- | --- |
| nested | The object parsed from the local text JSON string. |
| prefix | The prefix to prepend before local text keys. |
| languageID | The language ID. |
| registry | The registry to add texts to. |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)