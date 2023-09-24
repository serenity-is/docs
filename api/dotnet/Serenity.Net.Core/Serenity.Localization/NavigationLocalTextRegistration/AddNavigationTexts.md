# NavigationLocalTextRegistration.AddNavigationTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds navigation item related texts

```csharp
public static void AddNavigationTexts(this ILocalTextRegistry registry, ITypeSource typeSource, 
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
* class [NavigationLocalTextRegistration](../NavigationLocalTextRegistration.md)