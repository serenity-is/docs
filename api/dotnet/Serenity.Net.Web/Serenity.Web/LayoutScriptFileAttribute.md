# LayoutScriptFileAttribute class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Declares a JS file that should be included in the layout on every page, usually rendered with `@Html.LayoutScriptFiles()`. This is intended for dynamically loaded libraries that need their scripts to be available on all pages, without depending on a page specific entry point. The declared files are also exposed as a predefined dynamic bundle named [`ScriptName`](./LayoutScriptBundleScript/ScriptName.md), which can be referenced from a bundle definition (e.g. `dynamic://Bundle.LayoutScriptFiles`). Note that the predefined bundle is generated once and cached, so it does not follow feature toggles dynamically; use `@Html.LayoutScriptFiles()` for that.

```csharp
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class LayoutScriptFileAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [LayoutScriptFileAttribute](LayoutScriptFileAttribute/LayoutScriptFileAttribute.md)(…) | Creates a new instance of the attribute. |
| [Order](LayoutScriptFileAttribute/Order.md) { get; set; } | Gets or sets the order among the included files. Files with a lower order are included first. Defaults to `0`. |
| [Path](LayoutScriptFileAttribute/Path.md) { get; } | Gets the app relative (`~/`) JS file path. |
| [RequireAnyFeature](LayoutScriptFileAttribute/RequireAnyFeature.md) { get; set; } | Gets or sets a value indicating whether any of the [`RequireFeatures`](./LayoutScriptFileAttribute/RequireFeatures.md) should be enabled instead of all of them. |
| [RequireFeatures](LayoutScriptFileAttribute/RequireFeatures.md) { get; set; } | Gets or sets the set of feature toggles this file depends on. When set, the file is only included if all (or any, see [`RequireAnyFeature`](./LayoutScriptFileAttribute/RequireAnyFeature.md)) of the features are enabled. |

## See Also

* **Source:** *[LayoutScriptFileAttribute.cs](https://github.com/serenity-is/Serenity/blob/9a2446d846f519fbbaf51efc2ecb18e288be61be/src/web/Mvc/Bundling/LayoutScriptFiles/LayoutScriptFileAttribute.cs)*