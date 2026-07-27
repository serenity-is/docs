# HtmlCspExtensions.CspNonce method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Gets a nonce value for use in script and style elements. Automatically generates and stores it in the current HTTP context items and adds it to the CSP directives.

```csharp
public static string CspNonce(this IHtmlHelper html, bool addDirectives = true)
```

| parameter | description |
| --- | --- |
| html | Html helper |
| addDirectives | True to add CSP directives for script-src, style-src, font-src |

## See Also

* class [HtmlCspExtensions](../HtmlCspExtensions.md)