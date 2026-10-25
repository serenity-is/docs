# IScriptBundleManager interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for a script bundling manager.

```csharp
public interface IScriptBundleManager
```

## Members

| name | description |
| --- | --- |
| [IsEnabled](IScriptBundleManager/IsEnabled.md) { get; } | Returns `true` if bundling is enabled. |
| [GetBundleIncludes](IScriptBundleManager/GetBundleIncludes.md)(…) | Gets the list of bundle includes. |
| [GetScriptBundle](IScriptBundleManager/GetScriptBundle.md)(…) | Gets the script bundle containing a script URL. |
| [Reset](IScriptBundleManager/Reset.md)() | Resets the script bundle manager. |
| [ScriptsChanged](IScriptBundleManager/ScriptsChanged.md)() | A method that can be called to clear the script file cache. |

## See Also

* **Source:** *[IScriptBundleManager.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/ScriptBundling/IScriptBundleManager.cs)*