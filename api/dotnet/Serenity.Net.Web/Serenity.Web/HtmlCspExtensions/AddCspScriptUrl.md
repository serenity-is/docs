# HtmlCspExtensions.AddCspScriptUrl method

Adds a Content Security Policy `script-src` directive for the given URL and returns the URL. This can be used in script include helpers for external URLs.

```csharp
public static string AddCspScriptUrl(this IHtmlHelper html, string url)
```

| parameter | description |
| --- | --- |
| html | The HTML helper. |
| url | The URL. |

## Return Value

The URL.

## See Also

* class [HtmlCspExtensions](../HtmlCspExtensions.md)