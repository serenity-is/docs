# LayoutCssFileOptions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Options for layout CSS files declared with [`LayoutCssFileAttribute`](./LayoutCssFileAttribute.md).

```csharp
public class LayoutCssFileOptions
```

## Public Members

| name | description |
| --- | --- |
| [LayoutCssFileOptions](LayoutCssFileOptions/LayoutCssFileOptions.md)() | The default constructor. |
| [Filter](LayoutCssFileOptions/Filter.md) { get; set; } | Gets or sets an optional filter that can be used to exclude some of the declared layout CSS files. Returning `false` skips the file. |

## See Also

* **Source:** *[LayoutCssFileOptions.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/LayoutCssFiles/LayoutCssFileOptions.cs)*