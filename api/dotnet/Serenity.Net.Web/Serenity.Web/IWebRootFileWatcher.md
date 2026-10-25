# IWebRootFileWatcher interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Provides change tokens for web files (under `wwwroot` or static web assets), usually only in development, by reusing physical file providers.

```csharp
public interface IWebRootFileWatcher
```

## Members

| name | description |
| --- | --- |
| [GetChangeToken](IWebRootFileWatcher/GetChangeToken.md)(…) | Gets a change token that fires when the given web relative file changes, or `null` if watching is not available (e.g. not in development, or the file has no physical path). |
| [RegisterCallback](IWebRootFileWatcher/RegisterCallback.md)(…) | Registers a callback that is invoked when any of the given app relative files changes. Only the first registration for a given key is honored, so callers may invoke this on every request without accumulating subscriptions. Only available in development. |

## See Also

* **Source:** *[IWebRootFileWatcher.cs](https://github.com/serenity-is/Serenity/blob/9a2446d846f519fbbaf51efc2ecb18e288be61be/src/web/Common/IWebRootFileWatcher.cs)*