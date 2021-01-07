# EnumLocalTextRegistration.AddEnumTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds local text translations defined implicitly by Description attributes in enumeration classes. Only enum values that has Description attribute are added as local text. By default, enums are registered in format: "Enums.{EnumerationTypeFullName}.{EnumValueName}". EnumerationTypeFullName, is fullname of the enumeration type. This can be overridden by attaching a EnumKey attribute.

```csharp
public static void AddEnumTexts(this ILocalTextRegistry registry, ITypeSource typeSource, 
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
* class [EnumLocalTextRegistration](../EnumLocalTextRegistration.md)