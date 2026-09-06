# HtmlScriptExtensions.StyleBundle method

Renders individual link elements for all CSS files in a bundle if bundling is disabled, and renders a single link element containing the bundle URL if it is enabled.

```csharp
public static HtmlString StyleBundle(this IHtmlHelper helper, string bundleKey)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |
| bundleKey | The bundle key. |

## Return Value

The rendered style bundle element.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Helper or *bundleKey* is `null`. |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)