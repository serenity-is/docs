# IGetAllTexts.GetAllTexts method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets all local text entries.

```csharp
public IDictionary<LanguageIdKeyPair, string> GetAllTexts(bool pending)
```

| parameter | description |
| --- | --- |
| pending | `true` to return pending (not yet approved) texts. |

## Return Value

A dictionary of all local text entries.

## See Also

* struct [LanguageIdKeyPair](../../Serenity.Localization/LanguageIdKeyPair.md)
* interface [IGetAllTexts](../IGetAllTexts.md)