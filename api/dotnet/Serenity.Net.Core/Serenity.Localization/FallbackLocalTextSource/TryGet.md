# FallbackLocalTextSource.TryGet method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns the localized representation that corresponds to the local text key, or a fallback if none is found in the registry.

```csharp
public string TryGet(string languageID, string key, bool pending)
```

| parameter | description |
| --- | --- |
| key | The local text key (e.g. Enums.Month.June). |
| languageID | The language identifier. |
| pending | If pending approval text should be used. |

## Return Value

The localized text, a fallback, or `null` if none is found.

## See Also

* class [FallbackLocalTextSource](../FallbackLocalTextSource.md)