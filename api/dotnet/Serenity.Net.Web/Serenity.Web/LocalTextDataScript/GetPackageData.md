# LocalTextDataScript.GetPackageData method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets a local text package as a dictionary.

```csharp
public static IDictionary<string, string> GetPackageData(ILocalTextRegistry registry, 
    string includes, string languageId, bool isPending, string packageId = null)
```

| parameter | description |
| --- | --- |
| registry | The text registry. |
| includes | The includes regex. |
| languageId | The language ID. |
| isPending | `true` to include pending texts. |
| packageId | The package ID. |

## Return Value

A dictionary of local text keys and values.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *registry* is `null`. |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextDataScript](../LocalTextDataScript.md)