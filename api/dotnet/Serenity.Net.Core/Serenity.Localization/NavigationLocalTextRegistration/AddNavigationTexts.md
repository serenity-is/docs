# NavigationLocalTextRegistration.AddNavigationTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds navigation item related texts.

```csharp
public static void AddNavigationTexts(this ILocalTextRegistry registry, ITypeSource typeSource, 
    string languageID = "")
```

| parameter | description |
| --- | --- |
| registry | The registry to add texts to. |
| typeSource | The type source to search for navigation item attributes in. |
| languageID | The language ID texts will be added for (default is the invariant language). |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [NavigationLocalTextRegistration](../NavigationLocalTextRegistration.md)