# FallbackLocalTextSource.TryGet method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns localized representation which corresponds to the local text key or the fallback if none found in the registry.

```csharp
public string TryGet(string languageID, string key, bool pending)
```

| parameter | description |
| --- | --- |
| key | Local text key (e.g. Enums.Month.June) |
| languageID | Language identifier |
| pending | If pending approval text should be used |

## See Also

* class [FallbackLocalTextSource](../FallbackLocalTextSource.md)