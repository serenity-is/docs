# ScriptFile class
**namespace:** *[Serenity.Plugins](../README.md#serenity.plugins-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A plugin script file registration.

```csharp
public class ScriptFile
```

## Public Members

| name | description |
| --- | --- |
| [ScriptFile](ScriptFile/ScriptFile.md)() | The default constructor. |
| [Path](ScriptFile/Path.md) { get; set; } | Gets or sets the path to the file. Should start with "./" corresponding to the plugin folder. |

## Remarks

This type is part of a legacy plugin system design and is no longer used by the framework. Use the `LayoutScriptFile` assembly attribute instead to declare scripts that should be included in the layout.

## See Also

* **Source:** *[ScriptFile.cs](https://github.com/serenity-is/Serenity/blob/42921a2cabf9c9256331037e2f6cd60672b97071/src/core/Plugins/ScriptFile.cs)*