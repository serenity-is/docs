# EnumLocalTextRegistration.AddEnumTexts method

Adds local text translations defined implicitly by DescriptionAttribute attributes in enumeration classes. Only enum values that have a DescriptionAttribute are added as local text. By default, enums are registered in the format "Enums.{EnumerationTypeFullName}.{EnumValueName}", where EnumerationTypeFullName is the full name of the enumeration type. This can be overridden by attaching an [`EnumKeyAttribute`](../../Serenity.ComponentModel/EnumKeyAttribute.md).

```csharp
public static void AddEnumTexts(this ILocalTextRegistry registry, ITypeSource typeSource, 
    string languageID = "")
```

| parameter | description |
| --- | --- |
| registry | The registry to add texts to. |
| typeSource | The type source to search for enumeration classes in. |
| languageID | The language ID texts will be added for (default is the invariant language). |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [EnumLocalTextRegistration](../EnumLocalTextRegistration.md)