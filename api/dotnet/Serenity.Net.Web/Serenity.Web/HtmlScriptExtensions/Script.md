# HtmlScriptExtensions.Script method

Renders a script include element. If bundling is enabled, it may contain the bundle URL instead of the script URL. If the bundle containing the script file is already rendered in this context, it will return an empty string.

```csharp
public static HtmlString Script(this IHtmlHelper helper, string includeJS)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |
| includeJS | The script URL. |

## Return Value

The rendered script element.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | HTML helper or *includeJS* is `null`. |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)