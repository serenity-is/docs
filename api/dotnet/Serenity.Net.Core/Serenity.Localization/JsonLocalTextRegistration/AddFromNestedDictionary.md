# JsonLocalTextRegistration.AddFromNestedDictionary method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds translation from a hierarchical local text dictionary parsed from JSON file.

```csharp
public static void AddFromNestedDictionary(IDictionary<string, object> nested, string prefix, 
    string languageID, ILocalTextRegistry registry)
```

| parameter | description |
| --- | --- |
| nested | Object parsed from local text JSON string |
| prefix | Prefix to prepend before local text keys |
| languageID | Language ID |
| registry | Registry |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)