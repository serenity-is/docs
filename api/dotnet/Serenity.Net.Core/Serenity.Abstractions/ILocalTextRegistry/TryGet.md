# ILocalTextRegistry.TryGet method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns the localized representation that corresponds to the local text key, or `null` if none is found in the source.

```csharp
public string TryGet(string languageID, string key, bool pending)
```

| parameter | description |
| --- | --- |
| key | The local text key (e.g. Enums.Month.June). |
| languageID | The language identifier. |
| pending | Include pending (not approved) texts. |

## Return Value

The localized text, or `null` if none is found.

## See Also

* interface [ILocalTextRegistry](../ILocalTextRegistry.md)