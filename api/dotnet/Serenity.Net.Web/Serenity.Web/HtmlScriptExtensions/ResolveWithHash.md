# HtmlScriptExtensions.ResolveWithHash method

Resolves a content URL by adding its hash with a `?v=` prefix.

```csharp
public static HtmlString ResolveWithHash(this IHtmlHelper helper, string contentUrl)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |
| contentUrl | The content URL. |

## Return Value

The resolved URL with its hash.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Helper or *contentUrl* is `null`. |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)