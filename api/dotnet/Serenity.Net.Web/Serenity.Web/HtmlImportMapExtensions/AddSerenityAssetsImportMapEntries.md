# HtmlImportMapExtensions.AddSerenityAssetsImportMapEntries method

Adds import map entries for modules provided via Serenity.Assets like tiptap, jspdf, etc.

```csharp
public static void AddSerenityAssetsImportMapEntries(this HttpContext context, 
    bool overwrite = true)
```

| parameter | description |
| --- | --- |
| context | The HTTP context. |
| overwrite | `true` (default) to overwrite existing entries if any. |

## See Also

* class [HtmlImportMapExtensions](../HtmlImportMapExtensions.md)