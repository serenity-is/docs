# HtmlCspExtensions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Contains CSP related extension methods for HTML helpers and HTTP contexts.

```csharp
public static class HtmlCspExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddCspDirective](HtmlCspExtensions/AddCspDirective.md)(…) | Adds a Content Security Policy directive to the current HTTP context items. (3 methods) |
| static [AddCspScriptUrl](HtmlCspExtensions/AddCspScriptUrl.md)(…) | Adds a Content Security Policy script-src directive for the given URL and returns the URL. This can be used in script include helpers for external URLs. |
| static [CspNonce](HtmlCspExtensions/CspNonce.md)(…) | Gets a nonce value for use in script and style elements. Automatically generates and stores it in the current HTTP context items and adds it to the CSP directives. |
| static [GetCspDirective](HtmlCspExtensions/GetCspDirective.md)(…) | Gets a Content Security Policy directive added via AddCspDirective merged with any manual values provided. The string includes the final semicolon. This can be used to render parts of the CSP header or meta tag content. |

## See Also

* **Source:** *[HtmlCspExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/HtmlCspExtensions.cs)*