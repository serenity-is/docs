# PropertyItemsLocalTextRegistration.AddPropertyItemsTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds local text translations defined implicitly by DisplayName, Tab, Placeholder, Hint etc. attributes used in Column/Form etc. definitions.

```csharp
public static void AddPropertyItemsTexts(this ILocalTextRegistry registry, ITypeSource typeSource, 
    string languageID = "")
```

| parameter | description |
| --- | --- |
| typeSource | Type source to search for enumeration classes in |
| languageID | Language ID texts will be added (default is invariant language) |
| registry | Registry |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [PropertyItemsLocalTextRegistration](../PropertyItemsLocalTextRegistration.md)