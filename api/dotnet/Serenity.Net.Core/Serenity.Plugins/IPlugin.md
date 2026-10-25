# IPlugin interface
**namespace:** *[Serenity.Plugins](../README.md#serenity.plugins-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for plugins.

```csharp
public interface IPlugin
```

## Remarks

This type is part of a legacy plugin system design and is no longer used by the framework. Its responsibilities are superseded by other mechanisms, e.g. `LayoutCssFile`/`LayoutScriptFile` for layout assets, `NavigationLink` for navigation items, and dependency injection based registration (e.g. `AddAutoRegisteredServices`) for services.

## See Also

* **Source:** *[IPlugin.cs](https://github.com/serenity-is/Serenity/blob/42921a2cabf9c9256331037e2f6cd60672b97071/src/core/Plugins/IPlugin.cs)*