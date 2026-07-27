# HtmlCspExtensions.GetCspDirective method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets a Content Security Policy directive added via AddCspDirective merged with any manual values provided. The string includes the final semicolon. This can be used to render parts of the CSP header or meta tag content.

```csharp
public static HtmlString GetCspDirective(this IHtmlHelper html, string directiveName, 
    params string[] manualValues)
```

| parameter | description |
| --- | --- |
| html | Html helper |
| directiveName | CSP directive name |
| manualValues | Manual values to include in the directive. Note that these values will be automatically quoted if they look like keywords ([A-Za-z0-9_-] only) and are not already quoted. |

## See Also

* class [HtmlCspExtensions](../HtmlCspExtensions.md)