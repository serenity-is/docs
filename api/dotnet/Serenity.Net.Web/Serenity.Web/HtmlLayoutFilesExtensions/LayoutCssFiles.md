# HtmlLayoutFilesExtensions.LayoutCssFiles method

Renders stylesheet links for all the CSS files declared with [`LayoutCssFileAttribute`](../LayoutCssFileAttribute.md) and resolved by [`ILayoutCssFileProvider`](../ILayoutCssFileProvider.md), so that dynamically loaded libraries can contribute layout styles without a page specific entry point. When CSS bundling is enabled ([`Enabled`](../CssBundlingOptions/Enabled.md)), the files are concatenated into one dynamic CSS bundle served from `~/DynJS.axd/`; otherwise a link is rendered for each file. Returns an empty string if there are no files, or if the result was already included in this context.

```csharp
public static HtmlString LayoutCssFiles(this IHtmlHelper helper, Func<string, bool>? filter = null)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |
| filter | An optional predicate applied to each file url (e.g. `~/path/file.css`). Return `false` to exclude a file. |

## Return Value

The rendered stylesheet link elements.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *helper* is `null`. |

## See Also

* class [HtmlLayoutFilesExtensions](../HtmlLayoutFilesExtensions.md)