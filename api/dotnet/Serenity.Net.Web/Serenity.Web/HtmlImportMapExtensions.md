# HtmlImportMapExtensions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Contains import map related extension methods for HTML helpers and HTTP contexts.

```csharp
public static class HtmlImportMapExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddImportMapEntry](HtmlImportMapExtensions/AddImportMapEntry.md)(…) | Adds an entry to the import map for the current HTML view, associating a module specifier with its address and optional integrity value. |
| static [AddSerenityAssetsImportMapEntries](HtmlImportMapExtensions/AddSerenityAssetsImportMapEntries.md)(…) | Adds import map entries for modules provided via Serenity.Assets like tiptap, jspdf, etc. |
| static [RenderImportMap](HtmlImportMapExtensions/RenderImportMap.md)(…) | Renders an HTML import map script element based on the current view's import map configuration. |

## See Also

* **Source:** *[HtmlImportMapExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/HtmlImportMapExtensions.cs)*