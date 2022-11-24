# HtmlScriptExtensions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Contains Serenity related helper methods that can be used in Razor CSHTML files

```csharp
public static class HtmlScriptExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [GetLocalTextContent](HtmlScriptExtensions/GetLocalTextContent.md)(…) | Gets the text content of a local text script |
| static [GetLocalTextInclude](HtmlScriptExtensions/GetLocalTextInclude.md)(…) | Gets the script URL for a local text script |
| static [LocalTextScript](HtmlScriptExtensions/LocalTextScript.md)(…) | Gets a script element for including a local text script |
| static [ResolveWithHash](HtmlScriptExtensions/ResolveWithHash.md)(…) | Resolves a content URL by adding its hash with "?v=" prefix. |
| static [Script](HtmlScriptExtensions/Script.md)(…) | Renders a script include element. If bundling is enabled, it may contain the bundle URL instead of the script URL. If the bundle containing the script file is already rendered in this context, it will return an empty string. |
| static [ScriptBundle](HtmlScriptExtensions/ScriptBundle.md)(…) | Renders individual script elements for all JS files in a bundle if bundling is disabled, and renders a single script element containing the bundle URL if it is enabled. |
| static [StyleBundle](HtmlScriptExtensions/StyleBundle.md)(…) | Renders individual link elements for all CSS files in a bundle if bundling is disabled, and renders a single link element containing the bundle URL if it is enabled. |
| static [Stylesheet](HtmlScriptExtensions/Stylesheet.md)(…) | Renders a CSS stylesheet link element. If bundling is enabled, it may contain the bundle URL instead of the CSS URL. If the bundle containing the CSS file is already rendered in this context, it will return an empty string. |

## See Also

* **Source:** *[HtmlScriptExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/HtmlScriptExtensions.cs)*