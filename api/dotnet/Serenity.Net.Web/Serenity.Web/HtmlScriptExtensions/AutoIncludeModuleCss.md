# HtmlScriptExtensions.AutoIncludeModuleCss method

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