# LocalTextDataScript.GetPackageData method
**namespace:** *[SerenityIs.Administration](../../README.md#serenityis.administration-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets a local text package as a dictionary

```csharp
public static IDictionary<string, string> GetPackageData(ILocalTextRegistry registry, 
    string includes, string languageId, bool isPending)
```

| parameter | description |
| --- | --- |
| registry | Text registry |
| includes | Includes regex |
| languageId | Language ID |
| isPending | True to include pending text |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Registry is null |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextDataScript](../LocalTextDataScript.md)