# HtmlScriptExtensions.StyleBundle method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Renders individual link elements for all CSS files in a bundle if bundling is disabled, and renders a single link element containing the bundle URL if it is enabled.

```csharp
public static HtmlString StyleBundle(this IHtmlHelper helper, string bundleKey)
```

| parameter | description |
| --- | --- |
| helper | HTML helper |
| bundleKey | Bundle key |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Helper or bundleKey is null |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)