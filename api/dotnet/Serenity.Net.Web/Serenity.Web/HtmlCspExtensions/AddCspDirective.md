# HtmlCspExtensions.AddCspDirective method (1 of 3)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Adds a Content Security Policy directive to the current HTTP context items.

```csharp
public static void AddCspDirective(this ControllerBase controller, string directiveName, 
    params string[] values)
```

| parameter | description |
| --- | --- |
| controller | Controller |
| directiveName | CSP directive name |
| values | CSP directive values. Note that these values will be automatically quoted if they look like keywords ([A-Za-z0-9_-] only) and are not already quoted. |

## See Also

* class [HtmlCspExtensions](../HtmlCspExtensions.md)

---

# HtmlCspExtensions.AddCspDirective method (2 of 3)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Adds a Content Security Policy directive to the current HTTP context items.

```csharp
public static void AddCspDirective(this HttpContext context, string directiveName, 
    params string[] values)
```

| parameter | description |
| --- | --- |
| context | Http context |
| directiveName | CSP directive name |
| values | CSP directive values. Note that these values will be automatically quoted if they look like keywords ([A-Za-z0-9_-] only) and are not already quoted. |

## See Also

* class [HtmlCspExtensions](../HtmlCspExtensions.md)

---

# HtmlCspExtensions.AddCspDirective method (3 of 3)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Adds a Content Security Policy directive to the current HTTP context items.

```csharp
public static void AddCspDirective(this IHtmlHelper html, string directiveName, 
    params string[] values)
```

| parameter | description |
| --- | --- |
| html | Html helper |
| directiveName | CSP directive name |
| values | CSP directive values. Note that these values will be automatically quoted if they look like keywords ([A-Za-z0-9_-] only) and are not already quoted. |

## See Also

* class [HtmlCspExtensions](../HtmlCspExtensions.md)