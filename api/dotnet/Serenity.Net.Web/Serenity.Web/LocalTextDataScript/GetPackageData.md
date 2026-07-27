# LocalTextDataScript.GetPackageData method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets a local text package as a dictionary

```csharp
public static IDictionary<string, string> GetPackageData(ILocalTextRegistry registry, 
    string includes, string languageId, bool isPending, string packageId = null)
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
* class [LocalTextDataScript](../LocalTextDataScript.md)