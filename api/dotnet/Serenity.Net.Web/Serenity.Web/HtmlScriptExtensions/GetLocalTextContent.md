# HtmlScriptExtensions.GetLocalTextContent method

Gets the text content of a local text script.

```csharp
public static string GetLocalTextContent(this IHtmlHelper page, string package, 
    bool isPending = false)
```

| parameter | description |
| --- | --- |
| page | The HTML helper. |
| package | The package key. |
| isPending | `true` to include pending texts. |

## Return Value

The local text script content.

## See Also

* class [HtmlScriptExtensions](../HtmlScriptExtensions.md)