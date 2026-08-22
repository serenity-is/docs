# IDynamicScriptManager interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Dynamic script manager abstraction.

```csharp
public interface IDynamicScriptManager
```

## Members

| name | description |
| --- | --- |
| event [ScriptChanged](IDynamicScriptManager/ScriptChanged.md) | Raised when a script changes. |
| [Changed](IDynamicScriptManager/Changed.md)(…) | Raises the script changed event for the script. |
| [CheckScriptRights](IDynamicScriptManager/CheckScriptRights.md)(…) | Checks access rights for the dynamic script. |
| [GetRegisteredScriptNames](IDynamicScriptManager/GetRegisteredScriptNames.md)() | Gets a list of registered script names. |
| [GetRegisteredScripts](IDynamicScriptManager/GetRegisteredScripts.md)() | Gets a dictionary of registered script names and their cached hashes. |
| [GetScriptInclude](IDynamicScriptManager/GetScriptInclude.md)(…) | Gets a script include element HTML markup. |
| [GetScriptText](IDynamicScriptManager/GetScriptText.md)(…) | Gets the dynamic script text. |
| [IfNotRegistered](IDynamicScriptManager/IfNotRegistered.md)(…) | Executes the callback if a script with the name is not already registered. |
| [IsRegistered](IDynamicScriptManager/IsRegistered.md)(…) | Returns whether a script with the name is registered. |
| [ReadScriptContent](IDynamicScriptManager/ReadScriptContent.md)(…) | Reads the content of a dynamic script. |
| [Register](IDynamicScriptManager/Register.md)(…) | Registers a dynamic script, potentially overriding a script with the same registration name. (2 methods) |
| [Reset](IDynamicScriptManager/Reset.md)() | Resets the dynamic script cache. |

## See Also

* **Source:** *[IDynamicScriptManager.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/DynamicScript/DynamicScript/IDynamicScriptManager.cs)*