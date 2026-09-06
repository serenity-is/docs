# LocalTextScript.GetLocalTextPackageScript method (1 of 2)

Gets the local text package script content.

```csharp
public static string GetLocalTextPackageScript(ILocalTextRegistry registry, 
    LocalTextPackages packages, string package, string languageId, bool isPending)
```

| parameter | description |
| --- | --- |
| registry | The text registry. |
| packages | The packages setting. |
| package | The package key. |
| languageId | The language ID. |
| isPending | `true` to include pending texts. |

## Return Value

The script content.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | The package key or packages setting is `null`. |

## See Also

* interface [ILocalTextRegistry](../../../Serenity.Net.Core/Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextPackages](../../../Serenity.Net.Core/Serenity.Web/LocalTextPackages.md)
* class [LocalTextScript](../LocalTextScript.md)

---

# LocalTextScript.GetLocalTextPackageScript method (2 of 2)

Gets a local text package script content.

```csharp
public static string GetLocalTextPackageScript(ILocalTextRegistry registry, string includes, 
    string languageId, bool isPending, string packageId = null)
```

| parameter | description |
| --- | --- |
| registry | The text registry. |
| includes | The includes regex. |
| languageId | The language ID. |
| isPending | `true` to include pending texts. |
| packageId | The package ID. |

## Return Value

The script content.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *registry* is `null`. |

## See Also

* interface [ILocalTextRegistry](../../../Serenity.Net.Core/Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextScript](../LocalTextScript.md)