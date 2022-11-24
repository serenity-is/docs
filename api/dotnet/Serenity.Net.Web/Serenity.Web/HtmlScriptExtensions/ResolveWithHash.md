# HtmlScriptExtensions.ResolveWithHash method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Resolves a content URL by adding its hash with "?v=" prefix.

```csharp
public static HtmlString ResolveWithHash(this IHtmlHelper helper, string contentUrl)
```

| parameter | description |
| --- | --- |
| helper | HTML helper |
| contentUrl | Content URL |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Helper or contentUrl is null |

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)