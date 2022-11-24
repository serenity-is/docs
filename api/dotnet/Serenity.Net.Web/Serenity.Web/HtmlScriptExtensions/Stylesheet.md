# HtmlScriptExtensions.Stylesheet method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Renders a CSS stylesheet link element. If bundling is enabled, it may contain the bundle URL instead of the CSS URL. If the bundle containing the CSS file is already rendered in this context, it will return an empty string.

```csharp
public static HtmlString Stylesheet(this IHtmlHelper helper, string cssUrl)
```

| parameter | description |
| --- | --- |
| helper | HTML helper |
| cssUrl | CSS Url |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | HTML helper or cssUrl is null |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)