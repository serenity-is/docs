# HtmlImportMapExtensions.AddImportMapEntry method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Adds an entry to the import map for the current HTML view, associating a module specifier with its address and optional integrity value.

```csharp
public static void AddImportMapEntry(this HttpContext context, string specifier, string address, 
    string integrity = null, bool? csp = null, bool overwrite = true)
```

| parameter | description |
| --- | --- |
| context | Http context. |
| specifier | The module specifier to map, such as a package name or relative path. Cannot be null. |
| address | The address or URL where the module can be loaded from. Cannot be null. |
| integrity | An optional integrity hash for the module, used to verify its contents. If null, no integrity value is set. |
| csp | Indicates whether to add a Content Security Policy directive for the module address. Set to `true` to add the directive; otherwise, `false`. |
| overwrite | True (default) to overwrite existing entries if any |

## Remarks

If the import map does not exist in the current HTTP context, a new one is created. This method is typically used in server-side rendering scenarios to manage JavaScript module imports and CSP headers.

## See Also

* class [HtmlImportMapExtensions](../HtmlImportMapExtensions.md)