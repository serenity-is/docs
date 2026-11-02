# ILayoutScriptFileProvider interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for a provider of layout script files declared with [`LayoutScriptFileAttribute`](./LayoutScriptFileAttribute.md).

```csharp
public interface ILayoutScriptFileProvider
```

## Members

| name | description |
| --- | --- |
| [GetFiles](ILayoutScriptFileProvider/GetFiles.md)() | Gets the list of app relative (`~/`) JS file urls to include in the layout, in the order they should be included, with duplicates removed. These don't include the ES modules, see [`GetModuleFiles`](./ILayoutScriptFileProvider/GetModuleFiles.md). |
| [GetModuleFiles](ILayoutScriptFileProvider/GetModuleFiles.md)() | Gets the list of app relative (`~/`) urls of the ES modules to include in the layout, in the order they should be included, with duplicates removed. |

## See Also

* **Source:** *[LayoutScriptFileProvider.cs](https://github.com/serenity-is/Serenity/blob/3ee4ed336eca3c73bc3d291124715a793a825afd/src/web/Mvc/Bundling/LayoutScriptFiles/LayoutScriptFileProvider.cs)*