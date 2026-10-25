# ILayoutCssFileProvider interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for a provider of layout CSS files declared with [`LayoutCssFileAttribute`](./LayoutCssFileAttribute.md).

```csharp
public interface ILayoutCssFileProvider
```

## Members

| name | description |
| --- | --- |
| [GetFiles](ILayoutCssFileProvider/GetFiles.md)() | Gets the list of app relative (`~/`) CSS file urls to include in the layout, in the order they should be included, with duplicates removed. |

## See Also

* **Source:** *[LayoutCssFileProvider.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/LayoutCssFiles/LayoutCssFileProvider.cs)*