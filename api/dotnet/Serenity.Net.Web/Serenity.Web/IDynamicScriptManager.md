# IDynamicScriptManager interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Dynamic script manager abstraction

```csharp
public interface IDynamicScriptManager
```

## Members

| name | description |
| --- | --- |
| event [ScriptChanged](IDynamicScriptManager/ScriptChanged.md) | Event that is raised when a script changed |
| [Changed](IDynamicScriptManager/Changed.md)(…) | Raises script changed event for the script |
| [CheckScriptRights](IDynamicScriptManager/CheckScriptRights.md)(…) | Checks access rights for the dynamic script |
| [GetRegisteredScriptNames](IDynamicScriptManager/GetRegisteredScriptNames.md)() | Gets a list of registered script names |
| [GetRegisteredScripts](IDynamicScriptManager/GetRegisteredScripts.md)() | Gets a dictionary of registered script names and their cached hashes |
| [GetScriptInclude](IDynamicScriptManager/GetScriptInclude.md)(…) | Gets a script include element HTML markup |
| [GetScriptText](IDynamicScriptManager/GetScriptText.md)(…) | Gets the dynamic script |
| [IfNotRegistered](IDynamicScriptManager/IfNotRegistered.md)(…) | Executes callback if a script with the name is not already registered |
| [IsRegistered](IDynamicScriptManager/IsRegistered.md)(…) | Returns if a script with the name is registered |
| [ReadScriptContent](IDynamicScriptManager/ReadScriptContent.md)(…) | Reads content of a dynamic script |
| [Register](IDynamicScriptManager/Register.md)(…) | Registers a dynamic script, potentially overriding a script with same registration name (2 methods) |
| [Reset](IDynamicScriptManager/Reset.md)() | Resets the dynamic script cache |

## See Also

* **Source:** *[IDynamicScriptManager.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScript/IDynamicScriptManager.cs)*