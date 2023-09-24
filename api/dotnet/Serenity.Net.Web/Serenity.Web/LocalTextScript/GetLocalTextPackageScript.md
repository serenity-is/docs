# LocalTextScript.GetLocalTextPackageScript method (1 of 2)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets local text package script content

```csharp
public static string GetLocalTextPackageScript(ILocalTextRegistry registry, 
    LocalTextPackages packages, string package, string languageId, bool isPending)
```

| parameter | description |
| --- | --- |
| registry | Text registry |
| packages | Packages setting |
| package | Package key |
| languageId | Language ID |
| isPending | True to include pending texts |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Package key or packages setting is null |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextPackages](../Serenity.Net.Core/../LocalTextPackages.md)
* class [LocalTextScript](../LocalTextScript.md)

---

# LocalTextScript.GetLocalTextPackageScript method (2 of 2)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets a local text package script content

```csharp
public static string GetLocalTextPackageScript(ILocalTextRegistry registry, string includes, 
    string languageId, bool isPending, string packageId = null)
```

| parameter | description |
| --- | --- |
| registry | Text registry |
| includes | Includes regex |
| languageId | Language ID |
| isPending | True to include pending text |
| packageId | Package ID |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Registry is null |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextScript](../LocalTextScript.md)