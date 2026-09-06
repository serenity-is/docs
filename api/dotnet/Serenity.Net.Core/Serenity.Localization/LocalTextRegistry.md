# LocalTextRegistry class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

The default [`ILocalTextRegistry`](../Serenity.Abstractions/ILocalTextRegistry.md) implementation.

```csharp
public class LocalTextRegistry : IGetAllTexts, ILanguageFallbacks, ILocalTextRegistry, IRemoveAll
```

## Public Members

| name | description |
| --- | --- |
| [LocalTextRegistry](LocalTextRegistry/LocalTextRegistry.md)() | The default constructor. |
| [Add](LocalTextRegistry/Add.md)(…) | Adds a local text entry to the registry. |
| [AddPending](LocalTextRegistry/AddPending.md)(…) | Adds a pending approval local text entry to the registry. These texts can only be seen while moderators are browsing the site. You can determine which users are moderators by implementing the `ILocalTextContext` interface and registering it through the service locator. |
| [GetAllAvailableTextsInLanguage](LocalTextRegistry/GetAllAvailableTextsInLanguage.md)(…) | Gets all available text keys (that have a translation in the language or any of its language fallbacks) and their local texts. |
| [GetAllTextKeys](LocalTextRegistry/GetAllTextKeys.md)(…) | Gets all text keys that are currently registered in any language. |
| [GetAllTexts](LocalTextRegistry/GetAllTexts.md)(…) |  |
| [GetLanguageFallbacks](LocalTextRegistry/GetLanguageFallbacks.md)(…) |  |
| [RemoveAll](LocalTextRegistry/RemoveAll.md)() | Removes all cached texts. |
| [SetLanguageFallback](LocalTextRegistry/SetLanguageFallback.md)(…) |  |
| [TryGet](LocalTextRegistry/TryGet.md)(…) | Converts the local text key to its representation in the requested language. Looks up the text in the requested language, its fallbacks, and the invariant language in order. If not found in any, `null` is returned. See [`SetLanguageFallback`](./LocalTextRegistry/SetLanguageFallback.md) for information about language fallbacks. |

## Remarks

This implementation also supports a "pending approval" mode. If your site needs some moderator approval before translations are published, you may put your site into this mode when some moderator is using the site by registering an ILocalTextContext provider. Thus, moderators can see unapproved texts while they are logged in to the site.

## See Also

* interface [ILocalTextRegistry](../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [IRemoveAll](../Serenity.Abstractions/IRemoveAll.md)
* interface [IGetAllTexts](../Serenity.Abstractions/IGetAllTexts.md)
* interface [ILanguageFallbacks](../Serenity.Abstractions/ILanguageFallbacks.md)
* **Source:** *[LocalTextRegistry.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/LocalTextRegistry.cs)*