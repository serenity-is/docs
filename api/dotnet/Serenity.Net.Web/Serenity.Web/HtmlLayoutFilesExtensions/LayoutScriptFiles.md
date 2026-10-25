# HtmlLayoutFilesExtensions.LayoutScriptFiles method

Renders script tags for all the JS files declared with [`LayoutScriptFileAttribute`](../LayoutScriptFileAttribute.md) and resolved by [`ILayoutScriptFileProvider`](../ILayoutScriptFileProvider.md), so that dynamically loaded libraries can contribute scripts without a page specific entry point. When script bundling is enabled ([`Enabled`](../ScriptBundlingOptions/Enabled.md)), the files are concatenated into one dynamic script bundle served from `~/DynJS.axd/`; otherwise a tag is rendered for each file. Returns an empty string if there are no files, or if the result was already included in this context.

```csharp
public static HtmlString LayoutScriptFiles(this IHtmlHelper helper, 
    Func<string, bool>? filter = null)
```

| parameter | description |
| --- | --- |
| helper | The HTML helper. |
| filter | An optional predicate applied to each file url (e.g. `~/path/file.js`). Return `false` to exclude a file. |

## Return Value

The rendered script elements.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *helper* is `null`. |

## See Also

* class [HtmlLayoutFilesExtensions](../HtmlLayoutFilesExtensions.md)