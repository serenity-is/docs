# CssFile class
**namespace:** *[Serenity.Plugins](../README.md#serenity.plugins-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A CSS file dependency for plugins.

```csharp
public class CssFile
```

## Public Members

| name | description |
| --- | --- |
| [CssFile](CssFile/CssFile.md)() | The default constructor. |
| [Path](CssFile/Path.md) { get; set; } | Gets or sets the path. Should start with "./" corresponding to the plugin folder. |

## Remarks

This type is part of a legacy plugin system design and is no longer used by the framework. Use the `LayoutCssFile` assembly attribute instead to declare CSS files that should be included in the layout.

## See Also

* **Source:** *[CssFile.cs](https://github.com/serenity-is/Serenity/blob/42921a2cabf9c9256331037e2f6cd60672b97071/src/core/Plugins/CssFile.cs)*