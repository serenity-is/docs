# LocalTextScript constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Local text dynamic script

```csharp
public LocalTextScript(ILocalTextRegistry registry, string package, string includes, 
    string languageId, bool isPending)
```

| parameter | description |
| --- | --- |
| registry | Text registry |
| package | Package key |
| includes | Includes regex |
| languageId | LanguageID |
| isPending | True to include pending texts |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## Remarks

Creates a new instance of the class

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextScript](../LocalTextScript.md)