# LayoutScriptFileProvider class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of [`ILayoutScriptFileProvider`](./ILayoutScriptFileProvider.md), which discovers [`LayoutScriptFileAttribute`](./LayoutScriptFileAttribute.md)s from the type source, filters them by the registered IFeatureToggles and an optional filter, and returns them ordered with duplicates removed.

```csharp
public class LayoutScriptFileProvider : ILayoutScriptFileProvider
```

| parameter | description |
| --- | --- |
| typeSource | The type source. |
| serviceProvider | The service provider, used to resolve the optional IFeatureToggles. |
| options | The layout script file options. |

## Public Members

| name | description |
| --- | --- |
| [LayoutScriptFileProvider](LayoutScriptFileProvider/LayoutScriptFileProvider.md)(…) | Default implementation of [`ILayoutScriptFileProvider`](./ILayoutScriptFileProvider.md), which discovers [`LayoutScriptFileAttribute`](./LayoutScriptFileAttribute.md)s from the type source, filters them by the registered IFeatureToggles and an optional filter, and returns them ordered with duplicates removed. |
| [GetFiles](LayoutScriptFileProvider/GetFiles.md)() |  |
| [GetModuleFiles](LayoutScriptFileProvider/GetModuleFiles.md)() |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## Remarks

Initializes a new instance of the [`LayoutScriptFileProvider`](./LayoutScriptFileProvider.md) class.

## See Also

* interface [ILayoutScriptFileProvider](./ILayoutScriptFileProvider.md)
* **Source:** *[LayoutScriptFileProvider.cs](https://github.com/serenity-is/Serenity/blob/3ee4ed336eca3c73bc3d291124715a793a825afd/src/web/Mvc/Bundling/LayoutScriptFiles/LayoutScriptFileProvider.cs)*