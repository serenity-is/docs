# HtmlImportMapExtensions.RenderImportMap method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Renders an HTML import map script element based on the current view's import map configuration.

```csharp
public static HtmlString RenderImportMap(this IHtmlHelper html)
```

| parameter | description |
| --- | --- |
| html | The HTML helper instance used to access the current view context and import map data. Cannot be null. |

## Return Value

An HtmlString containing a  element with the serialized import map, or an empty HtmlString if no import map is available.

## Remarks

Use this method in a Razor view to emit an import map for JavaScript module loading. The import map is retrieved from the current HTTP context and serialized to JSON. If no import map is configured, the method returns an empty result.

## See Also

* class [HtmlImportMapExtensions](../HtmlImportMapExtensions.md)