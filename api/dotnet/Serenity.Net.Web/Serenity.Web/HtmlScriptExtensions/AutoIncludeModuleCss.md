# HtmlScriptExtensions.AutoIncludeModuleCss method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Automatically includes the corresponding `.css` file for an ES module if it exists next to the `.js` file.

```csharp
public static HtmlString AutoIncludeModuleCss(this IHtmlHelper helper, string module)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |
| module | The ES module. |

## Return Value

The rendered stylesheet link element, or an empty string if no CSS file exists.

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)