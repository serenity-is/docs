# HtmlCspExtensions.GetCspDirective method

Gets a Content Security Policy directive added via [`AddCspDirective`](./AddCspDirective.md) merged with any manual values provided. The string includes the final semicolon. This can be used to render parts of the CSP header or meta tag content.

```csharp
public static HtmlString GetCspDirective(this IHtmlHelper html, string directiveName, 
    params string[] manualValues)
```

| parameter | description |
| --- | --- |
| html | The HTML helper. |
| directiveName | The CSP directive name. |
| manualValues | The manual values to include in the directive. Note that these values will be automatically quoted if they look like keywords (`[A-Za-z0-9_-]` only) and are not already quoted. |

## Return Value

The rendered CSP directive.

## See Also

* class [HtmlCspExtensions](../HtmlCspExtensions.md)