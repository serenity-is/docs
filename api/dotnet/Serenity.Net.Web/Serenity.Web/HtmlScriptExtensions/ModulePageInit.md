# HtmlScriptExtensions.ModulePageInit method

Executes the default export of a module page, usually `pageInit`.

```csharp
public static HtmlString ModulePageInit(this IHtmlHelper html, string module, 
    object options = null, bool css = true)
```

| parameter | description |
| --- | --- |
| html | The HTML helper. |
| module | The module. |
| options | The options to pass to the module. |
| css | `true` to also include the module's CSS file. |

## Return Value

The rendered module page init script.

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)