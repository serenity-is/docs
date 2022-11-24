# HtmlScriptExtensions.Script method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Renders a script include element. If bundling is enabled, it may contain the bundle URL instead of the script URL. If the bundle containing the script file is already rendered in this context, it will return an empty string.

```csharp
public static HtmlString Script(this IHtmlHelper helper, string includeJS)
```

| parameter | description |
| --- | --- |
| helper | HTML helper |
| includeJS | Script url |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | HTML helper or includeJS is null |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)