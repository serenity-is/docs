# ILocalTextRegistry.TryGet method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Returns localized representation which corresponds to the local text key or null if none found in the source.

```csharp
public string TryGet(string languageID, string key, bool pending)
```

| parameter | description |
| --- | --- |
| key | Local text key (e.g. Enums.Month.June) |
| languageID | Language identifier |
| pending | Include pending (not approved) texts |

## See Also

* interface [ILocalTextRegistry](../ILocalTextRegistry.md)