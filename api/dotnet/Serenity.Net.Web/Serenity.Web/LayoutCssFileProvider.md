# LayoutCssFileProvider class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of [`ILayoutCssFileProvider`](./ILayoutCssFileProvider.md), which discovers [`LayoutCssFileAttribute`](./LayoutCssFileAttribute.md)s from the type source, filters them by the registered IFeatureToggles and an optional filter, and returns them ordered with duplicates removed.

```csharp
public class LayoutCssFileProvider : ILayoutCssFileProvider
```

| parameter | description |
| --- | --- |
| typeSource | The type source. |
| serviceProvider | The service provider, used to resolve the optional IFeatureToggles. |
| options | The layout CSS file options. |

## Public Members

| name | description |
| --- | --- |
| [LayoutCssFileProvider](LayoutCssFileProvider/LayoutCssFileProvider.md)(…) | Default implementation of [`ILayoutCssFileProvider`](./ILayoutCssFileProvider.md), which discovers [`LayoutCssFileAttribute`](./LayoutCssFileAttribute.md)s from the type source, filters them by the registered IFeatureToggles and an optional filter, and returns them ordered with duplicates removed. |
| [GetFiles](LayoutCssFileProvider/GetFiles.md)() |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## Remarks

Initializes a new instance of the [`LayoutCssFileProvider`](./LayoutCssFileProvider.md) class.

## See Also

* interface [ILayoutCssFileProvider](./ILayoutCssFileProvider.md)
* **Source:** *[LayoutCssFileProvider.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/LayoutCssFiles/LayoutCssFileProvider.cs)*