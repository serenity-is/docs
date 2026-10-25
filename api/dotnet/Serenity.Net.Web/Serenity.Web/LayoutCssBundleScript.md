# LayoutCssBundleScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

A predefined dynamic CSS bundle that concatenates the layout CSS files declared with [`LayoutCssFileAttribute`](./LayoutCssFileAttribute.md). It is registered under [`ScriptName`](./LayoutCssBundleScript/ScriptName.md) at startup, so it can be referenced from a bundle definition (e.g. `dynamic://CssBundle.LayoutCssFiles`) or rendered with `@Html.Stylesheet("dynamic://CssBundle.LayoutCssFiles")`.

```csharp
public class LayoutCssBundleScript : DynamicScript
```

| parameter | description |
| --- | --- |
| fileProvider | The layout CSS file provider. |
| bundleBuilder | The CSS bundle builder. |

## Public Members

| name | description |
| --- | --- |
| [LayoutCssBundleScript](LayoutCssBundleScript/LayoutCssBundleScript.md)(…) | A predefined dynamic CSS bundle that concatenates the layout CSS files declared with [`LayoutCssFileAttribute`](./LayoutCssFileAttribute.md). It is registered under [`ScriptName`](./LayoutCssBundleScript/ScriptName.md) at startup, so it can be referenced from a bundle definition (e.g. `dynamic://CssBundle.LayoutCssFiles`) or rendered with `@Html.Stylesheet("dynamic://CssBundle.LayoutCssFiles")`. |
| override [GetScript](LayoutCssBundleScript/GetScript.md)() |  |
| const [ScriptName](LayoutCssBundleScript/ScriptName.md) | The predefined registration name of the layout CSS bundle. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |

## Remarks

Unlike `Html.LayoutCssFiles()`, the file set is resolved by [`GetFiles`](./ILayoutCssFileProvider/GetFiles.md) the first time the script is generated and then cached, so it does not change dynamically when feature toggles change at runtime. Use `Html.LayoutCssFiles()` when the file set should follow feature toggles per request. Initializes a new instance of the [`LayoutCssBundleScript`](./LayoutCssBundleScript.md) class.

## See Also

* class [DynamicScript](../../Serenity.Net.Services/Serenity.Web/DynamicScript.md)
* **Source:** *[LayoutCssBundleScript.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/LayoutCssFiles/LayoutCssBundleScript.cs)*