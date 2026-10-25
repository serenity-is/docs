# HtmlLayoutFilesExtensions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Contains extensions for including layout CSS and JS files declared with [`LayoutCssFileAttribute`](./LayoutCssFileAttribute.md) / [`LayoutScriptFileAttribute`](./LayoutScriptFileAttribute.md).

```csharp
public static class HtmlLayoutFilesExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [LayoutCssFiles](HtmlLayoutFilesExtensions/LayoutCssFiles.md)(…) | Renders stylesheet links for all the CSS files declared with [`LayoutCssFileAttribute`](./LayoutCssFileAttribute.md) and resolved by [`ILayoutCssFileProvider`](./ILayoutCssFileProvider.md), so that dynamically loaded libraries can contribute layout styles without a page specific entry point. When CSS bundling is enabled ([`Enabled`](./CssBundlingOptions/Enabled.md)), the files are concatenated into one dynamic CSS bundle served from `~/DynJS.axd/`; otherwise a link is rendered for each file. Returns an empty string if there are no files, or if the result was already included in this context. |
| static [LayoutScriptFiles](HtmlLayoutFilesExtensions/LayoutScriptFiles.md)(…) | Renders script tags for all the JS files declared with [`LayoutScriptFileAttribute`](./LayoutScriptFileAttribute.md) and resolved by [`ILayoutScriptFileProvider`](./ILayoutScriptFileProvider.md), so that dynamically loaded libraries can contribute scripts without a page specific entry point. When script bundling is enabled ([`Enabled`](./ScriptBundlingOptions/Enabled.md)), the files are concatenated into one dynamic script bundle served from `~/DynJS.axd/`; otherwise a tag is rendered for each file. Returns an empty string if there are no files, or if the result was already included in this context. |

## See Also

* **Source:** *[HtmlLayoutFilesExtensions.cs](https://github.com/serenity-is/Serenity/blob/9a2446d846f519fbbaf51efc2ecb18e288be61be/src/web/Mvc/Html/HtmlLayoutFilesExtensions.cs)*