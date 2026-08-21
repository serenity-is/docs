# LocalTextRegistry.AddPending method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds a pending approval local text entry to the registry. These texts can only be seen while moderators are browsing the site. You can determine which users are moderators by implementing the `ILocalTextContext` interface and registering it through the service locator.

```csharp
public void AddPending(string languageID, string key, string text)
```

| parameter | description |
| --- | --- |
| languageID | The language ID (e.g. en-US, tr-TR). |
| key | The local text key. |
| text | The translated text. |

## See Also

* class [LocalTextRegistry](../LocalTextRegistry.md)