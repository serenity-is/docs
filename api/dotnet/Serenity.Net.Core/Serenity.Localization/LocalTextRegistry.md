# LocalTextRegistry class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default ILocalTextRegistry implementation.

```csharp
public class LocalTextRegistry : ILocalTextRegistry, IRemoveAll
```

## Public Members

| name | description |
| --- | --- |
| [LocalTextRegistry](LocalTextRegistry/LocalTextRegistry.md)() | The default constructor. |
| [Add](LocalTextRegistry/Add.md)(…) | Adds a local text entry to the registry |
| [AddPending](LocalTextRegistry/AddPending.md)(…) | Adds a pending approval local text entry to the registry. These texts can only be seen while moderators are browsing the site. You can determine which users are moderators by implementing ILocalTextContext interface, and registering it through the service locator. |
| [GetAllAvailableTextsInLanguage](LocalTextRegistry/GetAllAvailableTextsInLanguage.md)(…) | Gets all available text keys (that has a translation in language or any of its language fallbacks) and their local texts. |
| [GetAllTextKeys](LocalTextRegistry/GetAllTextKeys.md)(…) | Gets all text keys that is currently registered in any language |
| [RemoveAll](LocalTextRegistry/RemoveAll.md)() | Removes all cached texts |
| [SetLanguageFallback](LocalTextRegistry/SetLanguageFallback.md)(…) | Sets the language fallback of the specified language. When a text is not found in one language, LocalTextRegistry checks its language fallback for a translation. Some implicit language fallback definitions exist even if none set. For example, "en" is language fallback ID of "en-US" and "en-UK", "tr" is language fallback ID of "tr-TR". Also, invariant language ID ("") is an implicit fallback of all languages. |
| [TryGet](LocalTextRegistry/TryGet.md)(…) | Converts the local text key to its representation in requested language. Looks up text in requested language, its Fallbacks and invariant language in order. If not found in any, null is returned. See SetLanguageFallback for information about language fallbacks. |

## Remarks

This implementation also supports a "pending approval" mode. If your site needs some moderator approval before translations are published, you may put your site to this mode when some moderator is using the site by registering an ILocalTextContext provider. Thus, moderators can see unapproved texts while they are logged in to the site.

## See Also

* interface [ILocalTextRegistry](../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [IRemoveAll](../Serenity.Abstractions/IRemoveAll.md)
* **Source:** *[LocalTextRegistry.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/LocalTextRegistry.cs)*