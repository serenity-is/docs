# PropertyItemsLocalTextRegistration.AddPropertyItemsTexts method

Adds local text translations defined implicitly by DisplayNameAttribute, [`TabAttribute`](../../Serenity.ComponentModel/TabAttribute.md), [`PlaceholderAttribute`](../../Serenity.ComponentModel/PlaceholderAttribute.md), [`HintAttribute`](../../Serenity.ComponentModel/HintAttribute.md), etc. attributes used in Column/Form definitions.

```csharp
public static void AddPropertyItemsTexts(this ILocalTextRegistry registry, ITypeSource typeSource, 
    string languageID = "")
```

| parameter | description |
| --- | --- |
| registry | The registry to add texts to. |
| typeSource | The type source to search for property item types in. |
| languageID | The language ID texts will be added for (default is the invariant language). |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [PropertyItemsLocalTextRegistration](../PropertyItemsLocalTextRegistration.md)