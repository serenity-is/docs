# HtmlScriptExtensions.ScriptBundle method

Renders individual script elements for all JS files in a bundle if bundling is disabled, and renders a single script element containing the bundle URL if it is enabled.

```csharp
public static HtmlString ScriptBundle(this IHtmlHelper helper, string bundleKey)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |
| bundleKey | The bundle key. |

## Return Value

The rendered script bundle element.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Helper or *bundleKey* is `null`. |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)