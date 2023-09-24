# LocalTextRegistry class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default ILocalTextRegistry implementation.

```csharp
public class LocalTextRegistry : IGetAllTexts, ILanguageFallbacks, ILocalTextRegistry, IRemoveAll
```

## Public Members

| name | description |
| --- | --- |
| [LocalTextRegistry](LocalTextRegistry/LocalTextRegistry.md)() | The default constructor. |
| [Add](LocalTextRegistry/Add.md)(…) | Adds a local text entry to the registry |
| [AddPending](LocalTextRegistry/AddPending.md)(…) | Adds a pending approval local text entry to the registry. These texts can only be seen while moderators are browsing the site. You can determine which users are moderators by implementing ILocalTextContext interface, and registering it through the service locator. |
| [GetAllAvailableTextsInLanguage](LocalTextRegistry/GetAllAvailableTextsInLanguage.md)(…) | Gets all available text keys (that has a translation in language or any of its language fallbacks) and their local texts. |
| [GetAllTextKeys](LocalTextRegistry/GetAllTextKeys.md)(…) | Gets all text keys that is currently registered in any language |
| [GetAllTexts](LocalTextRegistry/GetAllTexts.md)(…) |  |
| [GetLanguageFallbacks](LocalTextRegistry/GetLanguageFallbacks.md)() |  |
| [RemoveAll](LocalTextRegistry/RemoveAll.md)() | Removes all cached texts |
| [SetLanguageFallback](LocalTextRegistry/SetLanguageFallback.md)(…) |  |
| [TryGet](LocalTextRegistry/TryGet.md)(…) | Converts the local text key to its representation in requested language. Looks up text in requested language, its Fallbacks and invariant language in order. If not found in any, null is returned. See SetLanguageFallback for information about language fallbacks. |

## Remarks

This implementation also supports a "pending approval" mode. If your site needs some moderator approval before translations are published, you may put your site to this mode when some moderator is using the site by registering an ILocalTextContext provider. Thus, moderators can see unapproved texts while they are logged in to the site.

## See Also

* interface [ILocalTextRegistry](../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [IRemoveAll](../Serenity.Abstractions/IRemoveAll.md)
* interface [IGetAllTexts](../Serenity.Abstractions/IGetAllTexts.md)
* interface [ILanguageFallbacks](../Serenity.Abstractions/ILanguageFallbacks.md)
* **Source:** *[LocalTextRegistry.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/LocalTextRegistry.cs)*