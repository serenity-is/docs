# LayoutCssFileAttribute class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Declares a CSS file that should be included in the layout on every page, usually rendered with `@Html.LayoutCssFiles()`. This is intended for dynamically loaded libraries that need their navigation or layout styles to be available on all pages, without depending on a page specific entry point. The declared files are also exposed as a predefined dynamic bundle named [`ScriptName`](./LayoutCssBundleScript/ScriptName.md), which can be referenced from a bundle definition (e.g. `dynamic://CssBundle.LayoutCssFiles`). Note that the predefined bundle is generated once and cached, so it does not follow feature toggles dynamically; use `@Html.LayoutCssFiles()` for that.

```csharp
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class LayoutCssFileAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [LayoutCssFileAttribute](LayoutCssFileAttribute/LayoutCssFileAttribute.md)(…) | Creates a new instance of the attribute. |
| [Order](LayoutCssFileAttribute/Order.md) { get; set; } | Gets or sets the order among the included files. Files with a lower order are included first. Defaults to `0`. |
| [Path](LayoutCssFileAttribute/Path.md) { get; } | Gets the app relative (`~/`) CSS file path. |
| [RequireAnyFeature](LayoutCssFileAttribute/RequireAnyFeature.md) { get; set; } | Gets or sets a value indicating whether any of the [`RequireFeatures`](./LayoutCssFileAttribute/RequireFeatures.md) should be enabled instead of all of them. |
| [RequireFeatures](LayoutCssFileAttribute/RequireFeatures.md) { get; set; } | Gets or sets the set of feature toggles this file depends on. When set, the file is only included if all (or any, see [`RequireAnyFeature`](./LayoutCssFileAttribute/RequireAnyFeature.md)) of the features are enabled. |

## See Also

* **Source:** *[LayoutCssFileAttribute.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/LayoutCssFiles/LayoutCssFileAttribute.cs)*