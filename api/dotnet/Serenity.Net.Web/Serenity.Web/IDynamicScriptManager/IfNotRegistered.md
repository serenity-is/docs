# IDynamicScriptManager.IfNotRegistered method

Executes the callback if a script with the name is not already registered.

```csharp
public void IfNotRegistered(string name, Func<IDynamicScript> callback)
```

| parameter | description |
| --- | --- |
| name | The registered name. |
| callback | The callback to execute. |

## See Also

* interface [IDynamicScript](../../../Serenity.Net.Core/Serenity.Web/IDynamicScript.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)