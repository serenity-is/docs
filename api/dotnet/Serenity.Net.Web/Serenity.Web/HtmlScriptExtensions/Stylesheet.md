# HtmlScriptExtensions.Stylesheet method

Renders a CSS stylesheet link element. If bundling is enabled, it may contain the bundle URL instead of the CSS URL. If the bundle containing the CSS file is already rendered in this context, it will return an empty string.

```csharp
public static HtmlString Stylesheet(this IHtmlHelper helper, string cssUrl)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |
| cssUrl | The CSS URL. |

## Return Value

The rendered stylesheet link element.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | HTML helper or *cssUrl* is `null`. |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)