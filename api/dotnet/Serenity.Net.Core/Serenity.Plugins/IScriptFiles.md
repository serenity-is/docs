# IScriptFiles interface
**namespace:** *[Serenity.Plugins](../README.md#serenity.plugins-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for plugins with script file dependencies.

```csharp
public interface IScriptFiles
```

## Members

| name | description |
| --- | --- |
| [GetScriptFiles](IScriptFiles/GetScriptFiles.md)() | Gets the script files. |

## Remarks

This type is part of a legacy plugin system design and is no longer used by the framework. Use the `LayoutScriptFile` assembly attribute instead to declare scripts that should be included in the layout.

## See Also

* **Source:** *[IScriptFiles.cs](https://github.com/serenity-is/Serenity/blob/42921a2cabf9c9256331037e2f6cd60672b97071/src/core/Plugins/IScriptFiles.cs)*